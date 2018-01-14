using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : Character {

	//public float speed;
	float moveVelocity;

	[SerializeField]
	private Transform[] groundPoints;

	[SerializeField]
	private float groundRadus;

	[SerializeField]
	private LayerMask whatIsGround;

	private bool isGrounded; 

	private bool jump;

	private float direction;

	private bool move;

	[SerializeField]
	private bool airControl;

	[SerializeField]
	private float jumpForce;

	private Rigidbody2D myRigidbody;


	// Use this for initialization
	public override void Start () {
		base.Start(); 
		myRigidbody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		float horizontal = Input.GetAxis ("Horizontal");

		isGrounded = IsGrounded ();

		if (move) {
			HandleMovement (direction);
			Flip (direction);
		} else {
			HandleMovement (horizontal);
			Flip (horizontal);
		}

		HandleLayers ();

		ResetValues ();
	}
	private void HandleMovement(float horizontal){

		if (myRigidbody.velocity.y < 0) {
			MyAnimator.SetBool ("land", true);
		}
		
		if (isGrounded || airControl) {
			myRigidbody.velocity = new Vector2 (horizontal * movementSpeed, myRigidbody.velocity.y);
		}

		MyAnimator.SetFloat ("speed", Mathf.Abs(horizontal));

		if(isGrounded && jump) {
			isGrounded = false;
			myRigidbody.AddForce (new Vector2 (0, jumpForce));
			MyAnimator.SetTrigger ("jump");
		}

	}
		
	private void Flip(float horizontal) {
		if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight) {
			ChangeDirection ();
		}
	}
	private void ResetValues() {
		jump = false; 

	}

	private bool IsGrounded() {
		if (myRigidbody.velocity.y <= 0) {
			foreach (Transform point in groundPoints) {
				Collider2D[] colliders = Physics2D.OverlapCircleAll (point.position, groundRadus, whatIsGround);

				for (int i = 0; i < colliders.Length; i++) {
					if (colliders [i].gameObject != gameObject) {

						MyAnimator.ResetTrigger("jump");
						MyAnimator.SetBool ("land", false);
						return true;
					}
				}
			}
		}

		return false;
	}

	private void HandleLayers() {
		if (!isGrounded) {
			MyAnimator.SetLayerWeight (1, 1);
		} else {
			MyAnimator.SetLayerWeight (1, 0);
		}
	}

	public void onTriggerEnter2D (Collider2D other) {
		print ("bar1");

		if (other.tag == "FirstBar") {
			print ("bar1");
		}
	}

	public void BtnMove(float direction) {
		this.direction = direction;
		this.move = true;
	}

	public void BtnStopMove() {
		this.direction = 0;
		move = false;
	}
}

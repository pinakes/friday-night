using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour {

	[SerializeField]
	protected float movementSpeed;

	protected bool facingRight;

	public Animator MyAnimator { get; private set; }

	// Use this for initialization
	public virtual void Start () {
		facingRight = true;

		MyAnimator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeDirection() {
		facingRight = !facingRight;
		transform.localScale = new Vector3 (transform.localScale.x * -1, 1, 1);
	}
}

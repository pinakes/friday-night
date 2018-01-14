using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxiController : MonoBehaviour {

	public float movementSpeed = 10;

	public int maxXPosition = -25;

	private Vector3 initialPos;
	private Quaternion initialRotation;


	// Use this for initialization
	void Start () {
		//taxiPosition = gameObject.transform.position.x;

		initialPos = transform.position;
		initialRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.left * movementSpeed * Time.deltaTime);

		if (gameObject.transform.position.x <= maxXPosition) {

			transform.position = initialPos;
			transform.rotation = initialRotation;
		}

	}
}

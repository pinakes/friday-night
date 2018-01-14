using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceSight : MonoBehaviour {

	[SerializeField]
	private Police police;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			police.Target = other.gameObject;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.tag == "Player") {
			police.Target = null;
		}
	}
}

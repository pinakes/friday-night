using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPoliceState {
	void Execute ();
	void Enter (Police police);
	void Exit ();
	void OnTriggerEnter (Collider2D other);
}

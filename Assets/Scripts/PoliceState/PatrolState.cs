using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : IPoliceState {

	private Police police;

	private float patrolTimer;

	private float patrolDuration = 6f;

	public void Execute ()
	{
		Patrol ();
		police.Move ();
		if (police.Target != null) {
			police.ChangeState (new RangedState ());
		}
	}

	public void Enter (Police police)
	{
		this.police = police;
	}

	public void Exit ()
	{
		
	}

	public void OnTriggerEnter (Collider2D other)
	{
		if(other.tag == "Edge") {
			police.ChangeDirection ();	
		}
	}
	private void Patrol() {

		patrolTimer += Time.deltaTime;

		if (patrolTimer >= patrolDuration) {
			police.ChangeState (new IdleState());
		}
	}
}

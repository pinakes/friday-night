using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IPoliceState {

	private Police police;

	private float idleTimer;

	private float idleDuration = 3f;

	public void Execute ()
	{
		Idle ();
		if (police.Target != null) {
			//police.ChangeState (new PatrolState ());
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
		
	}
	private void Idle() {
		police.MyAnimator.SetFloat ("speed", 0);

		idleTimer += Time.deltaTime;

		if (idleTimer >= idleDuration) {
			police.ChangeState (new PatrolState ());
		}
	}
}

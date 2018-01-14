using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedState : IPoliceState {

	private Police police;

	public void Execute ()
	{
		if (police.Target != null) {
			
			police.ChangeState (new MeleeState());
			//police.Move ();

		} else {
			police.ChangeState (new IdleState ());
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
}

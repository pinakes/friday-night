using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeleeState : IPoliceState {

	private Police police;

	private float AltTimer;

	//public GameObject txt;

	
	public void Execute ()
	{
		police.MyAnimator.SetFloat ("speed", 0);

		AltTimer += Time.deltaTime;
		if(AltTimer >= 2f ){
			Application.LoadLevel (3);
		}
	}
	public void Enter (Police police)
	{
		this.police = police;
		//Text txt = txt.GetComponent<Text>("Text");
		//txt = GameObject.GetComponent<UnityEngine.UI.Text>("Text");
		//txt = GameObject.GetComponent<Text>("Text");
		//txt.text=".";
	}
	public void Exit ()
	{
		
	}
	public void OnTriggerEnter (Collider2D other)
	{
		
	}
}

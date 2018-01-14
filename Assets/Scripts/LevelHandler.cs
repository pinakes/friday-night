using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelHandler : MonoBehaviour {

	private static LevelHandler instance;

	public static LevelHandler Instance {
		get { 
			if (instance == null) {
				instance = GameObject.FindObjectOfType<LevelHandler>();
			}
			return instance; 
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			startGame ();
		} else if (Input.GetKeyDown (KeyCode.Escape)) {
			beginning ();
		}
			
	}

	public void startGame() {
		Application.LoadLevel (1);
	}
	public void beginning() {
		Application.LoadLevel (0);
	}
	public void LoadBar(string name) {
		Application.LoadLevel (name);
	}
}

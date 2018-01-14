using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

	[SerializeField]
	private int nodeNumber;

	static int previus;

	static int current;

	void start(){
	}

	void OnMouseEnter(){
		
		if (previus == 0 && nodeNumber == 1) {
			previus = 1;
			print ("OK - clicked for the first time - "+previus);
		} else if (nodeNumber == (previus + 1) && nodeNumber < 4) {
			previus = previus + 1;
			print ("GOOD - keep going - "+previus);
		} else if (nodeNumber == (previus + 1) && nodeNumber >= 4) {
			previus = previus + 1;
			print ("Congratulation! - "+previus);
			Application.LoadLevel (1);
			previus = 0;
		} else {
			//print ("WRONG - game over - "+previus);
			previus = 0;
			Application.LoadLevel (4);
		}
	}

	static void nodeClicked(int cur){
		print(cur);
	}
}

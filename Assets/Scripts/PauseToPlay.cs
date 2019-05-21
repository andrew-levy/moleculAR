using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseToPlay : MonoBehaviour {

	public Sprite sp1;
	public Sprite sp2;
	public bool isPaused = false;
	// Use this for initialization
	void Start () {
		
	}

	public void changeImage() {
		if (!isPaused) {
			this.changeImage ();
		}

	}

}

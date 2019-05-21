using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickToLink : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void click () {
		Application.OpenURL ("https://en.wikipedia.org/wiki/VSEPR_theory");
	}
}

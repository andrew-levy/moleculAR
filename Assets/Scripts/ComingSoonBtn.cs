using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComingSoonBtn : MonoBehaviour {

    public Text text;
	// Use this for initialization
	void Start () {
		text.enabled = false;
	}
	
	// Update is called once per frame
	public void onClickShow () {
        text.enabled = true;
	}
}

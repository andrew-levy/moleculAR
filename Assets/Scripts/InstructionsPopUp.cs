using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsPopUp : MonoBehaviour {

    private bool isActive;
	// Use this for initialization
	void Start () {
        isActive = false;
	}
	
	public void closePopUp () {

		this.gameObject.SetActive (false);

	}

    public void TogglePopUp()
    {
        isActive = !isActive;
        this.gameObject.SetActive(isActive);
    }
}

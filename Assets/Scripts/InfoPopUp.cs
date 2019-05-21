using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using System.Collections.Generic;

public class InfoPopUp : MonoBehaviour {


    private bool isActive;

	void Start () {
        isActive = false;
	}


	public void openPopUp () {

		gameObject.SetActive (true);

	}

	public void closePopUp () {

		gameObject.SetActive (false);

	}

    public void TogglePopUp()
    {
        isActive = !isActive;
        gameObject.SetActive(isActive);
    }



		
}

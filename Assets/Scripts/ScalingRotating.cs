using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingRotating : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void onClickScaleUp() {

        if (transform.localScale.x <= .7)
        {
            transform.localScale += new Vector3(0.03F, 0.03F, 0.03F);
        }
	}


	public void onClickScaleDown() {
        if (transform.localScale.x > .05)
        {
            transform.localScale -= new Vector3(0.03F, 0.03F, 0.03F);
        }
	}


}

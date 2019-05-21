using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ObjectControllerRotate : MonoBehaviour {

    public Rigidbody body;

	void Start () {
        body = this.GetComponent<Rigidbody>();
	}
	

	void FixedUpdate () {
        Vector3 newVec = new Vector3(CrossPlatformInputManager.GetAxis("Vertical"), 
            CrossPlatformInputManager.GetAxis("Horizontal"));
        body.transform.Rotate(newVec*1.5F);
	}
}

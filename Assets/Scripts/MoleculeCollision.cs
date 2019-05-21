using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleculeCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	void OnCollisionEnter(Collision col) {

		if (col.gameObject.name == "mol1") {

			Destroy (this.gameObject);
			Debug.Log("collision detected");
		}


	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerAnimation : MonoBehaviour {



	public Animator anim;

	// Use this for initialization
	void Start () {
		//anim = this.GetComponentInParent<Animator> ();
	}



	void OnCollisionEnter(Collision col) {


		if (col.gameObject.name == "mol2" && anim != null) {

			anim.Play ("reaction");
		}


	}
}

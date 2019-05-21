using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using System.Linq;


public class imgTargetDetection : MonoBehaviour {

	StateManager sm;
	IEnumerable<TrackableBehaviour> activeTrackables;
	TrackableBehaviour active;

	public UnityEngine.UI.Image img;
	public UnityEngine.UI.Image infoImg;
	public Sprite sprite5;
	public Sprite sprite4;
	public Sprite sprite3;
	public Sprite sprite2;
	public Sprite sprite1;
	public Sprite spriteDefault;


	void Start() {
		
		sm = TrackerManager.Instance.GetStateManager ();
		activeTrackables = sm.GetActiveTrackableBehaviours ();
		TrackableBehaviour active = null;

	}

	// Update is called once per frame
	void Update () {
		
		sm = TrackerManager.Instance.GetStateManager ();
		activeTrackables = sm.GetActiveTrackableBehaviours ();

		if (atLeastOneTracked()) {
			
		//	removeText ();
			active = activeTrackables.ElementAt (0);
			setInfoImage ();

		} else {
		//	showText();
			if (spriteDefault != null) {
				infoImg.sprite = spriteDefault;
			}
		}
			
	
	}

	public bool atLeastOneTracked () {
		
		return activeTrackables.Any();
	}

	public void setInfoImage () {


			if (active.TrackableName.Equals ("Target5")) {
				if (sprite5 != null) {
					infoImg.sprite = sprite5;
				} 
			} else if (active.TrackableName.Equals ("Target4")) {
				if (sprite4 != null) {
					infoImg.sprite = sprite4;
				} 
			} else if (active.TrackableName.Equals ("Target3")) {
				if (sprite3 != null) {
					infoImg.sprite = sprite3;
				} 
			} else if (active.TrackableName.Equals ("Named2")) {
				if (sprite2 != null) {
					infoImg.sprite = sprite2;
				} 
			} else if (active.TrackableName.Equals ("Named1")) {
				if (sprite1 != null) {
					infoImg.sprite = sprite1;
				}
			}
				
	}

//	public void removeText () {
//		if (img != null) {
//			img.enabled = false;
//		}
//
//
//	}
//
//	public void showText () {
//		if (img != null) {
//			img.enabled = true;
//		}
//	}
}

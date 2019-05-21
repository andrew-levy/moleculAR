using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoCardSwipe : MonoBehaviour {

	Animator anim;
	Vector2 secondPressPos;
	Vector2 currentSwipe;
	Vector2 firstPressPos;

	bool isUp;

	// Use this for initialization
	void Start () {

		isUp = true;
		anim = this.GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {


		if (SystemInfo.deviceType == DeviceType.Handheld) {

			if (Input.touches.Length > 0) {
				Touch t = Input.GetTouch (0);
				if (t.phase == TouchPhase.Began) {
					//save began touch 2d point
					firstPressPos = new Vector2 (t.position.x, t.position.y);
				}
				if (t.phase == TouchPhase.Ended) {
					//save ended touch 2d point
					secondPressPos = new Vector2 (t.position.x, t.position.y);
		
					//create vector from the two points
					currentSwipe = new Vector3 (secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);
		
					//normalize the 2d vector
					currentSwipe.Normalize ();
		
					//swipe upwards
					if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f && firstPressPos.y <= Screen.height / 4) {
						Debug.Log ("up swipe");
						SwipeUp ();
					}
					//swipe down
					if (currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f && firstPressPos.y <= 2 * Screen.height / 3 && firstPressPos.y >= Screen.height / 3) {
						Debug.Log ("down swipe");
						SwipeDown ();
					}
		
				}
			}
		} else {

		// FOR TESTING ON COMPUTER (CLICK AND DRAG)

		if(Input.GetMouseButtonDown(0))
		{
			//save began touch 2d point
			firstPressPos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
		}
		if (Input.GetMouseButtonUp (0)) {
			//save ended touch 2d point
			secondPressPos = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);

			//create vector from the two points
			currentSwipe = new Vector2 (secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

			//normalize the 2d vector
			currentSwipe.Normalize ();

			//swipe upwards
			if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f && firstPressPos.y <= Screen.height/4) {
				Debug.Log ("up swipe");
				SwipeUp ();
			}
			//swipe down
			if (currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f && firstPressPos.y <= 2 * Screen.height/3 && firstPressPos.y >= Screen.height/3) {
				Debug.Log ("down swipe");
				SwipeDown ();
			}


		}

		}
	}

	public void SwipeDown () {
		if (isUp) {
			anim.Play ("swipeDownInfo");
			isUp = !isUp;
		}
	}

	public void SwipeUp () {
		if (!isUp) {
			anim.Play ("swipeUpInfo");
			isUp = !isUp;
		}


	}


}

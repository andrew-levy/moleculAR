using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracking : DefaultTrackableEventHandler {

	public Sprite sprite1;
	public Sprite def;
	public UnityEngine.UI.Image img; //= holder.GetComponentInChildren<UnityEngine.UI.Image> ();
	// Use this for initialization
	void Start () {
		
	}

	protected override  void OnTrackingFound()
	{
		base.OnTrackingFound ();
		img.sprite = sprite1;

	}

	protected override void OnTrackingLost()
	{
		base.OnTrackingLost ();
		img.sprite = def;
	}


}

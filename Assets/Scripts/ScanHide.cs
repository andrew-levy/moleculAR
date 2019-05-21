using UnityEngine;
using System.Collections;
using Vuforia;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class ScanHide : MonoBehaviour, ITrackableEventHandler {

	private TrackableBehaviour mTrackableBehaviour;

	private bool mHideScanOutline = false;
	private Rect mOutlineRect = new Rect(50,50,120,60);

	void Start () {
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
		Scene scene = SceneManager.GetActiveScene();
		List<GameObject> rootObjects = new List<GameObject>();
		scene.GetRootGameObjects(rootObjects);
		foreach (GameObject go in rootObjects) {
			print (go.name);
		}
	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		print ("tracked");
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED)
		{
			mHideScanOutline = true;
			GameObject.Find("Canvas").SetActive(false);
		}
		else
		{
			mHideScanOutline = false;
			//GameObject.Find("Scan Outline").SetActive(true);
		}
	}
}
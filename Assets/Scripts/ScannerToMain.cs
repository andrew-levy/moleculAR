using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScannerToMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Restart() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void toMain() {
		SceneManager.LoadScene(0);

		//SceneManager.LoadSceneAsync(0);
      //  UnityEditor.EditorUtility.UnloadUnusedAssetsImmediate();
    }
}

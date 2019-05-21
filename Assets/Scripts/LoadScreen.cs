using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScreen : MonoBehaviour {

    private int sceneIndex;
    private AsyncOperation async;

    // Use this for initialization
    void Start () {
        // both scene will always be loaded to reduce button lag..
        int index = SceneManager.GetActiveScene().buildIndex;
        if (index == 1)
        {
            this.sceneIndex = 0;
        } else
        {
            this.sceneIndex = 1;
        }

        StartLoadingScene();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void StartLoadingScene()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        //async = Application.LoadLevelAsync(sceneName);
        async = SceneManager.LoadSceneAsync(sceneIndex);
        async.allowSceneActivation = false;
        yield return async;
    }

    public void ActivateScene()
    {
        async.allowSceneActivation = true;
    }

    public void loadScene0() {
        // load scene

		SceneManager.LoadScene (0);
	//	SceneManager.LoadSceneAsync(0); // loads in background
     //   UnityEditor.EditorUtility.UnloadUnusedAssetsImmediate();
	}

	public void loadScene1() {
        // load scene
		SceneManager.LoadScene (1);
    //    SceneManager.LoadSceneAsync(1);
     //   UnityEditor.EditorUtility.UnloadUnusedAssetsImmediate();
    }

	public void loadScene2() {
        // load scene
		SceneManager.LoadScene (2);
    //    SceneManager.LoadSceneAsync(2);
     //   UnityEditor.EditorUtility.UnloadUnusedAssetsImmediate();
    }

	public void loadScene3() {
		// load scene
		SceneManager.LoadScene (3);
		//    SceneManager.LoadSceneAsync(2);
		//   UnityEditor.EditorUtility.UnloadUnusedAssetsImmediate();
	}
}

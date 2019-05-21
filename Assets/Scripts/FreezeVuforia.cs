using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class FreezeVuforia : MonoBehaviour {
    // Use this for initialization
    public Sprite play;
    public Sprite pause;
    public Button btn;

	public Sprite flashEnable;
	public Sprite flashDisable;
	public Button btn2;


	bool flash = true;
    bool freeze = true;
    
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void toggleFlash () {

		CameraDevice.Instance.SetFlashTorchMode (flash);
		if(flash) {
			btn2.image.sprite = flashDisable;
			flash = false;
		} else {
			btn2.image.sprite = flashEnable;
			flash = true;
		}

	}

	public void toggleFreeze() {
		VuforiaRenderer.Instance.Pause(freeze);
        
        if(freeze) {
            btn.image.sprite = play;
            freeze = false;
        } else {
            btn.image.sprite = pause;
            freeze = true;
        }
	}

}

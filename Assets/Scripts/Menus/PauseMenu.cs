using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
public class PauseMenu : MonoBehaviour {

    public int ButtonState = 0;
    public int LastButtonState = 1;
    public int Temp;
    //public GameObject Controller;
    public FirstPersonController FPSController;
    public GameObject SwordSwing;
    public GameObject Crosshair1;
    public GameObject Crosshair2;
    public GameObject PauseText;
    public GameObject ResumeButton;

    // Use this for initialization
    void Start () {
        FPSController = GameObject.FindObjectOfType<FirstPersonController>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButtonDown("Pause")) {
            Temp = LastButtonState;
            LastButtonState = ButtonState;
            ButtonState = Temp;            
        }
        if(ButtonState == 1) {
            FPSController.enabled = false;
            Time.timeScale = 0f;
            SwordSwing.GetComponent<SwingSword>().enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Crosshair1.SetActive(false);
            Crosshair2.SetActive(false);
            PauseText.SetActive(true);
            ResumeButton.SetActive(true);

        } else if(ButtonState == 0) {
            SwordSwing.GetComponent<SwingSword>().enabled = true;
            FPSController.enabled = true;
            Time.timeScale = 1.0f;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Crosshair1.SetActive(true);
            Crosshair2.SetActive(true);
            PauseText.SetActive(false);
            ResumeButton.SetActive(false);
        }
        
    }

    public void ResumeGame() {
        Temp = LastButtonState;
        LastButtonState = ButtonState;
        ButtonState = Temp;
    }

}



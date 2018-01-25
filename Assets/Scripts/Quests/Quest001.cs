using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest001 : MonoBehaviour {

    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject UIQuest;
    public GameObject ThePlayer;
    public GameObject NoticeCam;
    public GameObject QuestButton;
    int buttonState = 0;
    int lastButtonState = 1;
    int temp;

	// Update is called once per frame
	void Update() {
		TheDistance = PlayerCasting.DistanceFromTarget;
       // OnMouseOver();
       // OnMouseExit();
	}
    void OnMouseOver() {
        if(TheDistance <= 2) {
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);           
            if(Input.GetButtonDown("Action")) {               
                temp = buttonState;
                buttonState = lastButtonState;
                lastButtonState = temp;
            }
            if(buttonState == 1) {
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                UIQuest.SetActive(true);
                if(Input.GetButtonDown("Submit")) {
                    temp = buttonState;
                    buttonState = lastButtonState;
                    lastButtonState = temp;
                    QuestButton.GetComponent<Quest001Buttons>().AcceptButton();
                } else if(Input.GetButtonDown("Cancel")) {
                    temp = buttonState;
                    buttonState = lastButtonState;
                    lastButtonState = temp;
                    QuestButton.GetComponent<Quest001Buttons>().DeclineButton();
                }
            } else if(buttonState == 0) {
                ActionDisplay.SetActive(true);
                ActionText.SetActive(true);
                UIQuest.SetActive(false);
            }
        } else if(TheDistance > 2) {
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
            UIQuest.SetActive(false);
            buttonState = 0;
            lastButtonState = 1;
        }
    }
    void OnMouseExit() {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        UIQuest.SetActive(false);
        buttonState = 0;
        lastButtonState = 1;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001_complete : MonoBehaviour {

    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject UIQuest;
    public GameObject ThePlayer;
    public GameObject ExMark;
    public GameObject CompleteTrigger;

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
            ActionText.GetComponent<Text>().text = "Complete quest";
            if(Input.GetButtonDown("Action")) {
                ExMark.SetActive(false);
                GlobalEXP.currentExp += 100;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                CompleteTrigger.SetActive(false);
            } else if(TheDistance > 2) {
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
            }
        }
    }

    void OnMouseExit() {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        UIQuest.SetActive(false);

    }


}

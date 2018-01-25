using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Q1_Obj2 : MonoBehaviour {

    public float TheDistance;
    public GameObject TreasureChest;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject TheObjective;
    public int CloseObjective;
    public GameObject TakeSword;
    public GameObject ThisTrigger;

	// Update is called once per frame
	void Update () {
        TheDistance = PlayerCasting.DistanceFromTarget;
        if(CloseObjective == 3) {
            if(TheObjective.transform.localScale.y <= 0.0f) {
                CloseObjective = 0;
                TheObjective.SetActive(false);
            } else {
                TheObjective.transform.localScale -= new Vector3(0.0f,0.04f,0.0f);
            }
        }
	}

    void OnMouseOver() {
        if(TheDistance <= 2) {
            ActionText.GetComponent<Text>().text = "Open chest";
            ActionText.SetActive(true);
            ActionDisplay.SetActive(true);

            if(Input.GetButtonDown("Action")) {              
                TreasureChest.GetComponent<Animation>().Play("Q01_ChestOpen");
                TakeSword.SetActive(true);
                CloseObjective = 3;
                ActionText.SetActive(false);
                ActionDisplay.SetActive(false);
                ThisTrigger.SetActive(false);
            }
        } else if(TheDistance > 2) {
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
        }
    }
    void OnMouseExit() {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Q1_Obj3 : MonoBehaviour {

    public float TheDistance;
    public GameObject SwordInChest;
    public GameObject PlayerSword;
    public GameObject ActionText;
    public GameObject ActionDisplay;
    public GameObject TheObjective;
    public int CloseObjective;
    public GameObject ChestBlock;
    public GameObject ExMark;
    public GameObject QuestComplete;

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
            ActionText.GetComponent<Text>().text = "Take sword";
            ActionText.SetActive(true);
            ActionDisplay.SetActive(true);

            if(Input.GetButtonDown("Action")) {
                this.GetComponent<BoxCollider>().enabled = false;
                SwordInChest.SetActive(false);
                PlayerSword.SetActive(true);
                CloseObjective = 3;
                ActionText.SetActive(false);
                ActionDisplay.SetActive(false);
                ChestBlock.SetActive(true);
                ExMark.SetActive(true);
                QuestComplete.SetActive(true);
                ExMarkStatus.Status = 1;
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

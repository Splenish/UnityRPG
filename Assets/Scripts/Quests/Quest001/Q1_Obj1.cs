using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q1_Obj1 : MonoBehaviour {

    public GameObject TheObjective;
    public int CloseObjective = 0;

	// Update is called once per frame
	void Update () {
		if(CloseObjective == 1) {
            if(TheObjective.transform.localScale.y <= 0.0f) {
                CloseObjective = 0;
                TheObjective.SetActive(false);
            } else {
                TheObjective.transform.localScale -= new Vector3(0.0f,0.04f,0.0f);
            }
        }
	}

    void OnTriggerEnter() {
        if(QuestManager.ActiveQuestNumber >= 1) {
            StartCoroutine(FinishObjective());
        }
    }

    IEnumerator FinishObjective() {
        TheObjective.SetActive(true);
        yield return new WaitForSeconds(2);
        CloseObjective = 1;
    }

}

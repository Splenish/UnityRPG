using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001Buttons : MonoBehaviour {

    //public GameObject ThePlayer;
    //public GameObject NoticeCam;
    public GameObject UIQuest;
    public GameObject ActiveQuestBox;
    public GameObject Objective01;
    public GameObject Objective02;
    public GameObject Objective03;
    public GameObject QuestMarker;
    public GameObject TheNotice;
    public GameObject NoticeTrigger;

    public void AcceptButton() {
        UIQuest.SetActive(false);
        StartCoroutine(SetQuestUI());
    }
    IEnumerator SetQuestUI() {
        QuestMarker.SetActive(false);
        TheNotice.SetActive(false);
        NoticeTrigger.SetActive(false);
        ActiveQuestBox.GetComponent<Text>().text = "My first weapon";
        Objective01.GetComponent<Text>().text = "Reach yo mamas woods";
        Objective02.GetComponent<Text>().text = "Open the chest";
        Objective03.GetComponent<Text>().text = "Retrieve the weapon";
        QuestManager.ActiveQuestNumber += 1;
        yield return new WaitForSeconds(0.5f);
        ActiveQuestBox.SetActive(true);
        yield return new WaitForSeconds(1);
        Objective01.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Objective02.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Objective03.SetActive(true);
        yield return new WaitForSeconds(9);
        ActiveQuestBox.SetActive(false);
        Objective01.SetActive(false);
        Objective02.SetActive(false);
        Objective03.SetActive(false);
    }

    public void DeclineButton() {
        UIQuest.SetActive(false);
    }

}

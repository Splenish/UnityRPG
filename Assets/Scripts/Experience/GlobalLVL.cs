using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalLVL : MonoBehaviour {

    public static int CurrentLevel = 1;
    public int InternalLevel;

	// Use this for initialization
	void Start () {
        //CurrentLevel = 1;
	}
	
	// Update is called once per frame
	void Update () {
        InternalLevel = CurrentLevel;
	}
}

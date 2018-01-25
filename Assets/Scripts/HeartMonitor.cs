﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartMonitor : MonoBehaviour {

    public static int HealthValue;
    public int InternalHealt;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;

    void Start () {
		HealthValue = 1;
	}
	
	// Update is called once per frame
	void Update () {
		InternalHealt = HealthValue;

        if(HealthValue == 1) {
            Heart1.SetActive(true);
        }
        if(HealthValue == 2) {
            Heart2.SetActive(true);
        }
        if(HealthValue == 3) {
            Heart3.SetActive(true);
        }
    }
}

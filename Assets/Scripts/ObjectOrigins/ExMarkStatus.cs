using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExMarkStatus : MonoBehaviour {

    public GameObject ExMark;
    public static int Status;
    public Vector3 StartPos;

	// Use this for initialization
	void Start () {
        StartPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(Status == 1) {
            transform.position = StartPos;
            Status = 0;
        }
	}
}

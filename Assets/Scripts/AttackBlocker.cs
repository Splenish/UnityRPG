using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBlocker : MonoBehaviour {


    public static int BlockSword;
    public int InternalBlockSword;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        InternalBlockSword = BlockSword;	
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListOfEnemies : MonoBehaviour {

    public static List<GameObject> Enemies;
    public List<GameObject> internalEnemies;

	// Use this for initialization
	void Start () {
        Enemies = internalEnemies;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

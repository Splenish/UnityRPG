using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitRadiusScript : MonoBehaviour {

    public GameObject EnemyAttachedTo;


    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag.Equals("Player") == true) {
            EnemyAttachedTo.GetComponent<Animation>().Play("attack");
        }
    }
}

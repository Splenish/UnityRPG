using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour {

    public AudioSource HitSound;
    public int EnemyHealth;
    // Use this for initialization


    public void DeductPoints(int DamageAmount) {
        Debug.Log("ass");
        if(EnemyHealth > 1) { 
            HitSound.Play();
            EnemyHealth -= DamageAmount;
        }
    }



}

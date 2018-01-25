using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderEnemy : Enemy{

    //public GameObject TheSpider;
    public int SpiderStatus = 0;
    public int BaseXp = 100;
    public int CalculatedXp;
    //public AudioSource HitSound;

	// Use this for initialization
	void Start () {
        gameObject.tag = "Enemy";
        EnemyHealth = 10;
    }

    /*
    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag.Equals("Player") == true) {
            GetComponent<Animation>().Play("attack");
        }
    }*/

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag.Equals("Player") == true && SpiderStatus == 0) {
            GetComponent<Animation>().Play("attack");
        }
    }

    // Update is called once per frame
    void Update () {
        //Debug.Log(gameObject.name);
		if(EnemyHealth <= 0) {
            if(SpiderStatus == 0) {
                SpiderStatus = 6;
                CalculatedXp = BaseXp / GlobalLVL.CurrentLevel;
                GlobalEXP.currentExp += CalculatedXp;
                GetComponent<Animation>().Play("die");
                SpiderStatus = 1;
                //Destroy(gameObject);
            }
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InflictDamage : MonoBehaviour {


    public static int DamageAmount = 5;
    public float TargetDistance;
    public GameObject Enemy;
    //public string StruckEnemy;
    //public float AllowedRange = 2.7f;

	// Use this for initialization
	void Start () {
		
	}

    void Update () {

    }

    void OnCollisionEnter(Collision collision) {
        Enemy = collision.collider.gameObject;
        if(collision.gameObject.tag.Equals("Enemy") == true ) {
            //StartCoroutine(DisableCollisionOnHit());
            GetComponent<SphereCollider>().enabled = false;
            Enemy.GetComponent<Enemy>().DeductPoints(DamageAmount);
        }
    }

   /* IEnumerator DisableCollisionOnHit() {
        GetComponent<SphereCollider>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        GetComponent<SphereCollider>().enabled = false;
    }*/

    // Update is called once per frame
    /*void Update () {
		if(Input.GetButtonDown("Fire1")) {
            RaycastHit hit;
            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit)) {
                TargetDistance = hit.distance;
                if(TargetDistance <= AllowedRange) {
                    hit.transform.SendMessage("DeductPoints",DamageAmount,SendMessageOptions.DontRequireReceiver);
                }
            }
        }
	}*/
}

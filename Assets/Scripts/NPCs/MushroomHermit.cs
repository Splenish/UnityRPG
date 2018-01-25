using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomHermit : MonoBehaviour {

    public Rigidbody Hermit;
    public AudioSource Yell;


	// Use this for initialization
	void Start () {
        Hermit = GetComponent<Rigidbody>();
        Hermit.AddForce(Vector3.up * 10f);
        Yell = GetComponent<AudioSource>();
        StartCoroutine(WaitShit());
        //Hermit.isKinematic = true;
	}

    void OnCollisionEnter(Collision collision) {
        if(collision.collider.gameObject.name == "InflictDamageObject") {
            //Hermit.isKinematic = false;
            Hermit.AddForce(Vector3.up * 60f);
            Hermit.AddForce(Vector3.back * 50f);
            Hermit.AddForce(Vector3.left * 50f);
            //Hermit.AddForce(new Vector3(-50f,60f,-50f));
            Yell.Play();
        }   
    }

    IEnumerator WaitShit() {
        yield return new WaitForSeconds(1.0f);
    }

    // Update is called once per frame
    void Update () {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingSword : MonoBehaviour {

    public GameObject TheSword;
    public int SwordStatus;
    public Animation anim;
    public GameObject Collider;
    public AudioSource SwingSound;
	
	// Update is called once per frame
	void Update () {
		if(SwordStatus == 0 && Input.GetButtonDown("Fire1")) {
            StartCoroutine(SwingSwordFunction());
        }
	}
    IEnumerator SwingSwordFunction() {
        anim = TheSword.GetComponent<Animation>();
        SwordStatus = 1;
        anim.Play();
        SwordStatus = 2;
        SwingSound.Play();
        yield return new WaitForSeconds(anim.clip.length * 0.4f);
        Collider.GetComponent<SphereCollider>().enabled = true;
        yield return new WaitForSeconds(anim.clip.length * 0.6f);
        Collider.GetComponent<SphereCollider>().enabled = false;
        SwordStatus = 0;

    }
    
}

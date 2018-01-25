using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCollect : MonoBehaviour {

    public int RotateSpeed = 2;
    public float PositionSpeed;
    float positionCounter = 0.1f;
    public float positionIncrement = 0.01f;
    public AudioSource CollectSound;
    public GameObject ThisHeart;
    

	// Update is called once per frame
	void Update () {
	    transform.Rotate(0, RotateSpeed, 0, Space.World);
        PositionSpeed = (Mathf.Sin(positionCounter)/500);
        Vector3 temp = new Vector3(0, PositionSpeed, 0);
        ThisHeart.transform.position += temp;
        positionCounter += positionIncrement;
	}

    void OnTriggerEnter() {
        CollectSound.Play();
        HeartMonitor.HealthValue += 1;
        ThisHeart.SetActive(false);
    }
}

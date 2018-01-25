using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalEXP : MonoBehaviour {

    public static int currentExp;
    public int internalExp;
    private void Start() {
        currentExp = 0;
    }

    // Update is called once per frame
    void Update () {
        internalExp = currentExp;
	}
}

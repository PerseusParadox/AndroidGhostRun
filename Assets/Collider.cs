using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour {
    UIManager uimanager;
    private void Start () {
        UIManager uimanager = GameObject.Find ("Canvas").GetComponent<UIManager> ();
    }
    private void OnTriggerEnter (Collider other) {
        if ( other.tag == "Enemy" ) {
            uimanager.AddScore ();
        }
    }
}

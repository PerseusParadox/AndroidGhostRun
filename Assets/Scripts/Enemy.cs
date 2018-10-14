using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {


    public float speed = 5;
    void Update () {
        Movement ();
    }
    void Movement () {

        transform.Translate (Vector3.left * speed * Time.deltaTime, Space.World);


    }
    private void OnTriggerEnter (Collider other) {
        if ( other.tag == "Player" ) {
            Die ();
        }
    }
    void Die () {
        Destroy (this.gameObject);
    }
}

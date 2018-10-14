using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp : MonoBehaviour {

    int numOfLives = 3;
    Rigidbody rb;
    public float smooth;
    public float newposition;

    void Start () {
        rb = GetComponent<Rigidbody> ();
    }

    void Update () {

        if ( Input.GetKeyDown (KeyCode.W) ) {
            Vector3 newposition = transform.position + new Vector3 (0 , 15 , 0);
            while ( transform.position.y < 15 ) {
                transform.position = Vector3.Lerp (transform.position , newposition , 0.125f * Time.deltaTime);
            }

        }

    }
}

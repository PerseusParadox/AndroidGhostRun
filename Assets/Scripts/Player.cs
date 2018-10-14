using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    int numOfLives = 3;
    Rigidbody rigidbody;
    float newposition;
    void Start () {
        rigidbody = GetComponent<Rigidbody> ();
    }

    void Update () {
        
        if ( Input.GetKeyDown (KeyCode.W) ) {
            newposition = transform.position.y + 15;

        }
        while ( transform.position.y < newposition ) {
            if ( transform.position.y < 30 ) {
                transform.position = Vector3.Lerp (transform.position , transform.position + new Vector3 (transform.position.x , transform.position.y + 15 , 0) , 0.125f * Time.deltaTime);
            }
        }
    }
    void Movement () {
        
    }

    void LoseLife () {


    }
}

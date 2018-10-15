using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    public Transform player;
    public Vector3 offset = new Vector3 (62.81f , 16.34205f , -44.14f);
    public float smooth;
    Quaternion from;
    Quaternion to;
    private void Update () {

    }
    private void LateUpdate () {
        if ( player != null ) {
            Vector3 newPos;
            if ( player.position.y >= 0 && player.position.y < 15 ) {
                newPos = new Vector3 (62.81f , 24.17f , -44.14f);
            } else if ( player.position.y >= 15 && player.position.y < 30 ) {
                newPos = new Vector3 (62.81f , 25.76f , -44.14f);
            } else {
                newPos = new Vector3 (62.81f , 30.8f , -44.14f);
            }
            transform.position = Vector3.Lerp (transform.position , newPos , smooth * Time.deltaTime);

        }




    }
}

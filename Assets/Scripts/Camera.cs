using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    public Transform player;
    public Vector3 offset = new Vector3 (62.81f , 16.34205f , -44.14f);
    public float smooth;
    private void Update () {

    }
    private void LateUpdate () {
        if ( player != null ) {
            if ( player.position.y > 0 ) {
                transform.position = Vector3.Lerp (transform.position , player.transform.position + offset , smooth / 2 * Time.deltaTime);
            } else if ( player.position.y > player.position.y && player.position.y < 30 ) {
                transform.position = Vector3.Lerp (transform.position , player.transform.position + offset + new Vector3 (0 , -20 , 0) , smooth / 2 * Time.deltaTime);
            } else {
                transform.position = Vector3.Lerp (transform.position , player.transform.position + offset , smooth * 2 * Time.deltaTime);
            }
        }


    }
}

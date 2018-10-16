using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {
    public float speed;
    public GameObject particles;
    public GameObject sound;
    UIManager uimanager;
    void Start () {
        uimanager = GameObject.Find ("Canvas").GetComponent<UIManager> ();
    }

    void Update () {
        transform.Translate (Vector3.left * speed * Time.deltaTime , Space.World);
        if ( transform.position.x < -60f ) {
            Destroy (this.gameObject);
        }
    }
    private void OnTriggerEnter (Collider other) {


        if ( other.tag == "Player" ) {
            Instantiate (particles , transform.position , Quaternion.identity);
            Instantiate (sound , transform.position , Quaternion.identity);
            uimanager.AddScore ();
            Destroy (this.gameObject);
        }
    }
}

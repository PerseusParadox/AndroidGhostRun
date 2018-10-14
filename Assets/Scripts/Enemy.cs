using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public GameObject particleSys;
    public GameObject deathSound;
    public float speed = 5;
    void Update () {
        Movement ();
        if ( transform.position.x < -60f ) {
            Destroy (this.gameObject);
        }
    }
    void Movement () {

        transform.Translate (Vector3.left * speed * Time.deltaTime , Space.World);


    }
    private void OnTriggerEnter (UnityEngine.Collider other) {
        if ( other.tag == "Player" ) {
            Player player = other.GetComponent<Player> ();
            player.LoseLife ();
            Die ();

        }
    }
    void Die () {
        Instantiate (particleSys , transform.position , Quaternion.identity);
        Instantiate (deathSound , transform.position , Quaternion.identity);
        Destroy (this.gameObject);
    }
}

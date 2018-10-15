using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    int numOfLives = 3;
    public GameObject particleSys;
    public float smooth;
    Vector3 touchposition;
    AudioSource audioSource;
    [SerializeField]
    GameObject deathSound;
    public bool dead = false;
    void Start () {
        audioSource = GetComponent<AudioSource> ();

    }

    void Update () {
        Movement ();
    }
    void Movement () {

        if ( Input.touchCount > 0 ) {


            touchposition = ( Input.touches[0].position );
            if ( touchposition.y > 720 ) {
                if ( Input.touches[0].phase == TouchPhase.Began ) {

                    if ( transform.position.y < 30 ) {
                        transform.position = Vector3.Lerp (transform.position , transform.position + new Vector3 (0 , 15 , 0) , 1);

                    }

                } else if ( transform.position.y > 0 ) {
                    if ( touchposition.y < 720 ) {
                        transform.position = Vector3.Lerp (transform.position , transform.position - new Vector3 (0 , 15 , 0) , 1);

                    }
                }



            }

            Debug.Log (touchposition.y);

        }

    }

    public void LoseLife () {
        Instantiate (particleSys , transform.position , Quaternion.identity);
        numOfLives--;
        audioSource.Play ();
        if ( numOfLives < 1 ) {
            Instantiate (deathSound , transform.position , Quaternion.identity);
            dead = true;
            Destroy (this.gameObject);
        }

    }
}

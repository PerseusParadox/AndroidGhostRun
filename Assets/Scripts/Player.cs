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
    void Start () {
        audioSource = GetComponent<AudioSource> ();

    }

    void Update () {
        Movement ();
    }
    void Movement () {
#if UNITY_STANDALONE
        if ( transform.position.y < 30 && Input.GetKeyDown (KeyCode.W) ) {
            transform.position = Vector3.Lerp (transform.position , transform.position + new Vector3 (0 , 15 , 0) , 1);

        } else if ( transform.position.y > 0 && Input.GetKeyDown (KeyCode.S) ) {
            transform.position = Vector3.Lerp (transform.position , transform.position - new Vector3 (0 , 15 , 0) , 1);

        }
#else
        if ( Input.touchCount > 0 ) {


            /*if ( transform.position.y < 30 && Input.touchCount > 0 ) {
                Touch touch = Input.touches[9];

                transform.position = Vector3.Lerp (transform.position , transform.position + new Vector3 (0 , 15 , 0) , 1);

            } else if ( transform.position.y > 0 && Input.GetKeyDown (KeyCode.S) ) {
                transform.position = Vector3.Lerp (transform.position , transform.position - new Vector3 (0 , 15 , 0) , 1);

            }*/
            touchposition = ( Input.touches[0].position );
            if ( Input.touches[0].phase == TouchPhase.Began ) {
                if ( touchposition.y > 720 ) {
                    if ( transform.position.y < 30 ) {
                        transform.position = Vector3.Lerp (transform.position , transform.position + new Vector3 (0 , 15 , 0) , 1);

                    }

                } else if ( touchposition.y < 720 ) {
                    if ( transform.position.y > 0 ) {
                        transform.position = Vector3.Lerp (transform.position , transform.position - new Vector3 (0 , 15 , 0) , 1);

                    }
                }



            }

            Debug.Log (touchposition.y);

        }

    }
#endif
    public void LoseLife () {
        Instantiate (particleSys , transform.position , Quaternion.identity);
        numOfLives--;
        audioSource.Play ();
        if ( numOfLives < 1 ) {
            Instantiate (deathSound , transform.position , Quaternion.identity);
            Destroy (this.gameObject);
        }

    }
}

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
    Vector3 newPos;
    public bool dead = false;
    void Start () {
        audioSource = GetComponent<AudioSource> ();
        newPos = transform.position;

    }

    void Update () {
        Movement ();
        Debug.Log (newPos.magnitude);
    }
    void Movement () {

        if ( Input.touchCount > 0 ) {

            touchposition = ( Input.touches[0].position );
            if ( newPos.magnitude < 28 && touchposition.y > 720 ) {
                if ( Input.touches[0].phase == TouchPhase.Began ) {
                    newPos = transform.position + new Vector3 (0 , 15 , 0);
                }

            } else if ( newPos.magnitude > 2 && touchposition.y < 720 ) {
                if ( Input.touches[0].phase == TouchPhase.Began ) {
                    newPos = transform.position - new Vector3 (0 , 15 , 0);

                }
            }
        }
        transform.position = Vector3.Lerp (transform.position , newPos , smooth * Time.deltaTime);
        if ( transform.position.y > 30 ) {
            transform.position = new Vector3 (0 , 30 , 0);
        } else if ( transform.position.y < 0 ) {
            transform.position = Vector3.zero;
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

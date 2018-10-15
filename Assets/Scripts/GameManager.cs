using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {
    public bool gameOver = false;
    public Player player;
    void Start () {

    }

    void Update () {

        if ( player == null ) {
            gameOver = true;
            if ( Input.touchCount > 0 ) {
                SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
            }
        }


    }
}

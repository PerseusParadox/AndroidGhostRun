using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    public Text Score;
    public Text ResetText;
    public int score = 0;
    float timer = 0;
    float freq = 2;
    public GameObject player;
    public GameManager gameManager;
    void Start () {
        score = 0;
        gameManager = GameObject.Find ("GameManager").GetComponent<GameManager> ();

    }

    private void Update () {
        //Score
        Score.text = "Score: " + score;
        if ( player != null ) {

            if ( timer <= 0 ) {
                AddScore ();
                timer = freq;
            }
            timer -= Time.deltaTime;
        }
        if ( gameManager.gameOver == true ) {
            ResetText.enabled = true;
        }

    }
    public void AddScore () {
        score += 10;
        Score.text = "Score: " + score;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    public Text Score;
    public int score = 0;
    float timer = 0;
    float freq = 2;
    public GameObject player;
    void Start () {
        score = 0;


    }

    private void Update () {
        Score.text = "Score: " + score;
        if ( player != null ) {

            if ( timer <= 0 ) {
                AddScore ();
                timer = freq;
            }
            timer -= Time.deltaTime;
        }
    }
    public void AddScore () {
        score += 10;
        Score.text = "Score: " + score;
    }
}

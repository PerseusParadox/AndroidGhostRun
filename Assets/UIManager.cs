using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    public Text Score;
    public int score = 0;
    void Start () {
        score = 0;

    }

    void Update () {

    }

    public void AddScore () {
        score += 10;
        Score.text = "Score: " + score;
    }
}

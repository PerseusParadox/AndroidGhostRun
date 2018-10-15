using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    [SerializeField]
    private GameObject enemy;
    [SerializeField]
    private int[] positions;
    float timer;
    public float frequency;
    void Update () {
        timer -= Time.deltaTime;
        if ( timer <= 0 ) {
            int i = (int) Random.Range (0 , positions.Length);
            Instantiate (enemy , new Vector3 (transform.position.x , transform.position.y + positions[i]) , Quaternion.Euler (0 , 187 , 0));
            timer = frequency;
        }

    }
    

}

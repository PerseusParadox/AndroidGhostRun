using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    [SerializeField]
    private GameObject enemy;
    [SerializeField]
    private int[] positions;
    void Start () {


        //Quaternion currentRot = transform.rotation;
        int i = Random.Range ((int) 0 , (int) 3);
        Debug.Log (positions[i]);

        Instantiate (enemy , new Vector3 (transform.position.x , transform.position.y + positions[i] , 0) , Quaternion.Euler (0 , 187 , 0));
    }


}

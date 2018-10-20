using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyNSecScript : MonoBehaviour {
    public float secs;
    void Update () {
        Destroy (this.gameObject , secs);
    }
}

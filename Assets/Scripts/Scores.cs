using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scores : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.layer != 6 && other.gameObject.tag != "Hit")
        {   
            hits++;
            Debug.Log("You've bumped into a thing this many times: " + hits);
        } 
    }

}

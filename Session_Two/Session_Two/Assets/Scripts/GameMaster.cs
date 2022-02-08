using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public int score = 0; //create score
    private void OnTriggerEnter2D(Collider2D other) {
        
        score++; //add one to score 
        Debug.Log(score); //debug the score value 

    }
}

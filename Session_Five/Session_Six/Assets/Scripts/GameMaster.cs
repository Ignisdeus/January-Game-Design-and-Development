using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    void Start()
    {
        AddScore(0); 
    }

    public Text scoreDisplay; 
    public int score; 
     
    public void AddScore(int x){

        score += x; 
        scoreDisplay.text = score.ToString(); 
    }
}

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
    
    public float pitch = 1, timer = 0;

    private void Update() {
        if( timer > 0.5f){
            pitch =1f; 
        }

    }
    public void AddScore(int x){
        timer = 0; 
        score += x; 
        scoreDisplay.text = score.ToString(); 
    }
}

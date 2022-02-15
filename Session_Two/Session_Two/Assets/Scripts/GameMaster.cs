using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameMaster : MonoBehaviour
{
    void Start() {
        scoreDisplay.text= "0"; // set to 0 at the start
    }
    public Text scoreDisplay; // create scoreText
    public int score = 0; //create score
    private void OnTriggerEnter2D(Collider2D other) {
        score++; //add one to score 
        Debug.Log(score); //debug the score value
        scoreDisplay.text = score.ToString(); // send the score to the UI as a string. 
    }
    public GameObject panel; // UI panel
    public Text gameOverScore; // end of game score display
    bool gameIsOver = false; // bool to test the game stage
    public void GameOver(){
            gameIsOver = true;
            panel.SetActive(true); // turns the panel on. 
            gameOverScore.text = score.ToString(); // update game over score value 
            Destroy(gameObject.GetComponent<BoxCollider2D>()); // remove the box collider that adds the score. 
    }
    private void Update() {
        if(gameIsOver && Input.GetKeyDown(KeyCode.Space)){ // if game is over and player hits spacebar 
            ReloadLevel(); //Call Reloadlevel
        }
    }
    void ReloadLevel(){
        SceneManager.LoadScene(0); // load scene at index 0 
    }
}

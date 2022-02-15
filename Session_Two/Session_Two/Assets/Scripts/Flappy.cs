using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    Rigidbody2D myBody; 
    void Start()
    {
        myBody = gameObject.GetComponent<Rigidbody2D>(); // gets the rigid body as a ref 
    }

    public KeyCode flap; //store the flap key
    public float forceToAdd; //amount of force to add to the rigidbody
    void Update()
    {
        if(Input.GetKeyDown(flap)){ // check if it hit the flap key 
            myBody.AddForce(Vector2.up * forceToAdd); // adds force to the rigidbody
        }

        if(Mathf.Abs(transform.position.y) > 5.14f){ // check if im more then 5.14 away for 0 on Y 

            //Debug.Log("Dead"); // debug dead 
            GM.GetComponent<GameMaster>().GameOver(); // run the game master game over code. 
        }
    }

    public GameObject GM; 
    void OnCollisionEnter2D(Collision2D other) {
        //Destroy(gameObject); // kill flappy if hit by the pipes
        GM.GetComponent<GameMaster>().GameOver(); // run the game master game over code. 
    }
}

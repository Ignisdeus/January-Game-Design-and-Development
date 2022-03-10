using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    
    Animator anim; 
    void Start()
    {
        anim = gameObject.GetComponent<Animator>(); // gets the animator conponenet     
    }

    // Update is called once per frame
    void Update()
    {
        float hoz  = Input.GetAxisRaw("Horizontal"); // get input from x axis on keybord 

        if(hoz > 0) {
            gameObject.GetComponent<SpriteRenderer>().flipX = false; // flip the sprite to look in direction of movement 
        }
        if (hoz < 0) {
            gameObject.GetComponent<SpriteRenderer>().flipX = true; // flip the sprite to look in direction of movement 
        }



        if (Mathf.Abs(hoz) > 0){
            anim.SetInteger("Action", 1); // if moveing run 
        }else{
            anim.SetInteger("Action", 0); // if not moving idle  
        } 
    }
}

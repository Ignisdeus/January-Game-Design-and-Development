using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [Range(0, 15)]
    public float speed = 5.0f;     
    void Update()
    {
        //input
        float hoz = Input.GetAxisRaw("Horizontal"); // get horizontal value
        //if(Mathf.Abs(hoz) > 0){ // check for movement
            transform.Translate(Vector2.right * speed * hoz * Time.deltaTime); // move by a set amount on the x axis 
        //} 
       
       // Debug.Log(Time.deltaTime);
    }

}

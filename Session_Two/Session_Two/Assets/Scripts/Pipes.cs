using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float max; 
    void Start() {
        
        transform.position = new Vector2(transform.position.x, Random.Range(-max, max)); // adds randomness on y 

    }
    public float speed = 20f; // set speed at 20 as default
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); // move left at a rate of speed scaled by time. 

        if(transform.position.x < -10){ //if object is less then -10 on x axes
            Destroy(gameObject); //destory this object
        }
    }
}

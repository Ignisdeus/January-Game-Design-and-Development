using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    [Range(0f,10f)]
    public float speed = 5f; 
    public float minPoint, maxPoint; 
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);  // move then to the left
        if(transform.position.x < minPoint){
            transform.position = new Vector2(maxPoint, transform.position.y); // move to the starting point
        }
                                                                     
    }
}

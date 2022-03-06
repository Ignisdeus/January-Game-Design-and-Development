using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpAmount; 
    void Start()
    {
        
    }

    public float speed = 5f; 
    float targetZ = 0;
    public float phaseRate = 0.3f;  
    void Update()
    {
        float hoz = Input.GetAxis("Horizontal");// getting input from ether arrows or a and d key                    
        transform.Translate(Vector2.right * speed * hoz * Time.deltaTime); // moves left of right depending on hoz value

        if(Input.GetKeyDown(KeyCode.S) && transform.position.z < 0){
            //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + jumpAmount); 
            targetZ = targetZ + jumpAmount; 
        }
        if(Input.GetKeyDown(KeyCode.W)){
            //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - jumpAmount);
            targetZ = targetZ - jumpAmount; 
        }

         transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y, targetZ), phaseRate );
        
    }
}

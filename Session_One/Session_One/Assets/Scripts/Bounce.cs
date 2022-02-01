using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    int count = 0;
    public int multi = 5; 
    void OnCollisionEnter2D(Collision2D other) {
        
        count++; 
        Debug.Log(count * multi); 
        //Debug.LogWarning("Dead");
        // ++ add one
        // -- take one 
    }
}

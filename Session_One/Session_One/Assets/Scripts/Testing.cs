using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    int myInt = 5; // any whole number 
    float myFloat = 5.0f; // any floating point number a number with a . in it
    string myString = "hello World"; // a string of chars/ words 
    bool myBool = false; // ture or false swtiches 

    GameObject myObject; 
    BoxCollider2D myBox; 
    Rigidbody2D myRig; 
    Testing myTesting; 

    
    void Start()
    {
        Debug.Log("This is debug");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("This is Update");
    }
}

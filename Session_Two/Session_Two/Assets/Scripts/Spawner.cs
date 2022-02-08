using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
 
    public float delay = 0.8f; 
    void Start()
    {
        InvokeRepeating("SpawnPipe", delay, delay); // Call SpawnPipe at the rate of Delay
    }
    
    public GameObject pipe; //store my pipe game object
    void SpawnPipe(){

        Instantiate(pipe, transform.position, Quaternion.identity); // spawn the Pipe 
    }
}

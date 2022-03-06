using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundControle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject[] ground;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)){
            MoveGround(0);
        } 
        if(Input.GetKeyDown(KeyCode.W)){
            MoveGround(1);
        } 
    }

    void MoveGround(int key){

        Vector3[] startingPos = new Vector3[ground.Length];
        for(int i =0; i < ground.Length; i ++){
            startingPos[i] = ground[i].transform.position; 
        }
        if(key == 0){
            for(int i =0; i < ground.Length; i ++){ // move eveythingback 
                ground[i].transform.position = startingPos[(i + 1) % ground.Length]; 
            } 
        } 
    } 


    /*

     */


}

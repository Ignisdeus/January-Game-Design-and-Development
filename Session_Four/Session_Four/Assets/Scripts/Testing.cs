using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{


    private void Start() {
        
        for(int i =0; i < 60; i ++){ // is a loop does loop stuff 

            Debug.Log(5 * (i +1)); 
        }
    }
    int x = 5;
    private void Update() {

        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("Sword = " + Damage(100, 0.2f, 25)); // <-- whats going to happen ? 
            Debug.Log("Gun = " + Damage(300, 0.5f, 50)); 
        }// <-- whats going to happen ?
    }
    // medhod vs Funtion (maths ?)
    // 
    void ThisIsMedhod(){

        // something happens

    }

    float Damage(int baseDmg, float crit, float mod){

        float totalDmg = baseDmg + mod; // add baseDmg and Mod 
        if(Random.Range(0f, 1f) < crit){ // if crits 
            totalDmg *= 1.5f;// up damage by 1/2 
        }
        return totalDmg; // return total dmg 
    } 

    int ThisIsAFunction(){

       int y = x * 10;  

        return y; 

    }
}

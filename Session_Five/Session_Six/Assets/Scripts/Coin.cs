using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    GameObject GM; 
    AudioSource audioS; 
    public AudioClip coinPickUp; 
    private void Start() {
        
        GM = GameObject.FindGameObjectWithTag("GM"); // find the GM 
        audioS = gameObject.GetComponent<AudioSource>(); 
    }
    [Range(1,100)]
    public int score;
    public bool adv = false; 
    public void PlayerInteract()
    {
        if(collected == false){
            if(!adv){
                BasePickUp();
            }else{
                AdvPickUp();
            } 
        }
    }

    void AdvPickUp(){
        collected = true; 
        audioS.PlayOneShot(coinPickUp, 0.7f);
        float x = GM.GetComponent<GameMaster>().pitch; // get the current pitch value
        x = x + 0.15f;     
        audioS.pitch = x; 
        GM.GetComponent<GameMaster>().pitch = x;
        //add to score
        GM.GetComponent<GameMaster>().AddScore(score);
        Destroy(gameObject.GetComponent<BoxCollider2D>()); 
        Destroy(gameObject, 5f);

    } 

    void BasePickUp(){
            collected = true; 
            audioS.PlayOneShot(coinPickUp, 0.7f);
            //add to score
            GM.GetComponent<GameMaster>().AddScore(score);
            Destroy(gameObject.GetComponent<BoxCollider2D>()); 
            Destroy(gameObject, 5f);
    } 

    float speed = 2.5f;
    float alpha = 1f; 
    Color col = Color.white; 
    public float scale = 1; 
    bool collected = false; 
    void Update()
    {
        if(collected){
            transform.Translate(Vector2.up * speed * Time.deltaTime); 
            alpha -= Time.deltaTime * scale; 
            col.a = alpha;
            gameObject.GetComponent<SpriteRenderer>().color = col;
        }
    }
}

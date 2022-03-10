using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator anim; 
    Rigidbody2D rigidBody; 
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    public float jumpForce = 500f; 
    public float movementSpeed; 
    void Update()
    {
        float hoz = Input.GetAxisRaw("Horizontal"); 

        

        if(anim.GetInteger("Action") != 2){

            if(grounded){
                transform.Translate(Vector2.right * movementSpeed * hoz * Time.deltaTime); 
            }else{
                transform.Translate(Vector2.right * (movementSpeed * 0.5f) * hoz * Time.deltaTime); 
            }


            if(Mathf.Abs(hoz) > float.Epsilon){
                anim.SetInteger("Action",1);     
            }else{
                anim.SetInteger("Action",0);    
            }
            if(hoz > 0){
                gameObject.GetComponent<SpriteRenderer>().flipX = false; 
            }
            if(hoz < 0){
                gameObject.GetComponent<SpriteRenderer>().flipX = true; 
            }
            if(Input.GetMouseButton(0)){
                anim.SetInteger("Action", 2);
                StartCoroutine(AttackReset());
            }
            if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)){
                grounded = false; 
                anim.SetInteger("Action", 3);
                rigidBody.AddForce(Vector2.up * jumpForce); 
            }
            if(rigidBody.velocity.y < 0 && !grounded){
                anim.SetInteger("Action", 4);
            }        
        }
    }



    IEnumerator AttackReset(){
        yield return new WaitForSeconds(0.4f);
         anim.SetInteger("Action", 0); 
    }

    bool grounded = true;
    public GameMaster GM;

    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.gameObject.tag == "Coin"){
            GM.GetComponent<GameMaster>().AddScore(1);
            other.gameObject.AddComponent<Coin>(); 
        }
        if(other.gameObject.tag == "Heart"){
            GM.GetComponent<GameMaster>().AddScore(100);
            other.gameObject.AddComponent<Coin>(); 
        }

        grounded = true; 
        anim.SetInteger("Action", 0);
    }

}

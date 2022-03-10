using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.tag == "Coin"){
            Destroy(gameObject.GetComponent<CircleCollider2D>()); 
        }else{
            Destroy(gameObject.GetComponent<BoxCollider2D>()); 
        }
        Destroy(gameObject, 5f); 
    }

    float speed = 2.5f;
    float alpha = 1f; 
    Color col = Color.white; 
    public float scale = 1; 
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime); 
        alpha -= Time.deltaTime * scale; 
        col.a = alpha; 
        gameObject.GetComponent<SpriteRenderer>().color = col; 
    }
}

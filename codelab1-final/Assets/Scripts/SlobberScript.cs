using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlobberScript : MonoBehaviour
{
    //public GameObject slobber;

    /*public static SlobberScript instance; 
    
    void Start()
    {
        //set up the singleton
        if (instance == null) //if instance isn't set
        {
            instance = this; //set it to this instance
            DontDestroyOnLoad(gameObject); //Don't destory this gameObject
        }
        else  //otherwise, if we have a singleton already
        {
            Destroy(gameObject); //Destroy this instance
        }

    }*/


    // Update is called once per frame
    void Update()
    {
        
    }
   
    
    /*void OnCollisionEnter2D(Collision2D other)
    
    {
        transform.position = new Vector2( //teleport to random location 
            Random.Range(-4, 4), //bw -5 to 5 on x axis
            Random.Range(-4, 4)); //bw -5 to 5 on y axis
        
        Destroy(gameObject);
    }*/
    
    /*void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject); //destroy the bullet
    }*/
    /*void OnCollisionEnter2D(Collision2D collision) {
        if (Collision2D.GameObject.slobber == slobber) {
            Destroy (gameObject);
        }
    }*/
}

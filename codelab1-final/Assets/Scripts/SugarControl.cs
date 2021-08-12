using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SugarControl : MonoBehaviour 
{ 
    Rigidbody2D rb; //rigidbody 2d component 
    GameObject target; //gameobject to follow (mickey) 
    float moveSpeed; //how fast sugar will go 
    Vector3 directionToTarget; //var directionToTarget
    public int sugarHealth = 1; //int for sugar health
    
    void Start () {
        target = GameObject.Find ("mickey"); //look for mick, our target 
        rb = GetComponent<Rigidbody2D> (); //get the rigidbody component 
        moveSpeed = Random.Range (3f, 5f); //calculate a random move speed when it gets instantiated
        //is this too fast?
    }
	
    // Update is called once per frame
    void Update () {
        MoveSugar (); //move sugar
    }

    void MoveSugar()
    {
        if (target != null)
        {
            //if mickey is around 
            directionToTarget =
                (target.transform.position - transform.position).normalized; //target position - monster position
            rb.velocity = new Vector2(directionToTarget.x * moveSpeed,
                directionToTarget.y * moveSpeed);
        }
        else //otherwise 
            rb.velocity = Vector3.zero; //sugar doesn't do anything 
    }

    private void OnTriggerEnter2D(Collider2D other) //when you do a collider 
    {
        if (other.tag == "pewBullet") //if other.tag is equal to pewbullet tag 
        {
            if (sugarHealth > 0) 
            {
                sugarHealth--; //sugar gets hit 
            }
            else //otherwise
            {
                Destroy(gameObject); //DESTORRRYY
            }
        }
    }
}
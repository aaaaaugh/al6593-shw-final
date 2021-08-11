using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kibble : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    
    {
        transform.position = new Vector2( //teleport to random location 
            Random.Range(-4, 4), //bw -5 to 5 on x axis
            Random.Range(-4, 4)); //bw -5 to 5 on y axis
        
        GameManager.instance.score++; //increase the player's score using the Singleton!! so increases by + 1 

        Debug.Log("KIBBLE GET!");
    }
}

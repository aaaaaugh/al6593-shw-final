using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerScript : MonoBehaviour
{
    public float xRange; //random range for flower pos on the x axis

    const float MIN_SPEED = 0.01f; //min speed
    const float MAX_SPEED = 0.05f; //max speed
    const float MAX_Y = 10; //where to start w flower
    const float MIN_Y = -10; //where to recycle the flower

    float speed; 

    // Start is called before the first frame update
    void Start()
    {
        Reset(); //setup the flower
    }

    public void Reset()
    {
        speed = -Random.Range(MIN_SPEED, MAX_SPEED); //give it a random speed

        //set random flower pos
        transform.position = new Vector2( 
            Random.Range(-xRange, xRange),
            MAX_Y);
    }

    // Update is called once per frame
    void Update()
    {
        //move flower by speed
        transform.position = new Vector2(
            transform.position.x,
            transform.position.y + speed);

        //if the flower goes off, then...
        if(transform.position.y < MIN_Y){
            FlowerPool.instance.Push(gameObject); //recycle it into the pool
        }
    }
}
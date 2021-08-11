using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MickeyControl : MonoBehaviour
{ 
  
  Rigidbody2D rb2D; //var for the Rigidbody2d
  
  //public float health = 100; //set health at 0 
  //public TextMesh healthText; 

  public float forceAmount = 10; //public var for forceamount 

  public static MickeyControl instance; //sets up a singleton

  BaseAttack attack; 

  void Awake()
  {
    if (instance == null) //instance hasn't been set yet 
    {
      DontDestroyOnLoad(gameObject); //dont destroy this gameobject when loading a new scene
      instance = this; //set instance to this obj
    }
    else //otherwise, if it's already set to an obj...
    { 
      Destroy(gameObject); //DESTROyyyyyy so there's only ever one of the gameobj 
    }
  }

  void Start()
  {
    rb2D = GetComponent<Rigidbody2D>(); //get rigidbody2d off of this gameobj 
  }

  void Update()
  {
    attack = GetComponent<BaseAttack>();

    if (Input.GetKeyDown(KeyCode.Space))
    {
      attack.Attack();
    }
    
    if (Input.GetKey(KeyCode.W)) //when you press w
    {
      rb2D.AddForce(Vector2.up * forceAmount); //go up
    }

    if (Input.GetKey(KeyCode.S)) //when you press s 
    {
      rb2D.AddForce(Vector2.down * forceAmount); //go down
    }

    if (Input.GetKey(KeyCode.A)) //when you press a 
    {
      rb2D.AddForce(Vector2.left * forceAmount); //go left
    }

    if (Input.GetKey(KeyCode.D)) //when you press d 
    {
      rb2D.AddForce(Vector2.right * forceAmount); //go right
    }
  }
  

}

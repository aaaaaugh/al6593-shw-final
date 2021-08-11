using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FlowerPool : ObjectPool //Extends from the abstract ObjectPool
{
    public GameObject flower; //gameObject for this pool

    public static FlowerPool instance; //holds the singleton reference

    void Start()
    {
        if(instance == null){ //if the instance isn't set
            instance = this; //then set it to this instance
            DontDestroyOnLoad(gameObject); //Don't DESTROY
        } else { //otherwise if we have the singleton
            Destroy(gameObject); //DESTROOOOOY
        }
    }

    protected override GameObject GetNewObject(){ //override abstract method
        return Instantiate<GameObject>(flower); //makes it return flower 
    }

    //this allows flower to be used again
    public GameObject GetFlower(){
        GameObject recycledFlower = Get(); //Flower our of the stack (stack is LIFO) LAST IN FIRST OUT 
        
        recycledFlower.GetComponent<FlowerScript>().Reset(); //resets
        
        Debug.Log("GOT U"); //why isnt this working write debug 

        return recycledFlower; //return it
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectPool : MonoBehaviour //objectpoole extends from monobehaviour
//bc monobehaviour is also a type of oop. remember abstract cant be turned into an obj
{
    protected Stack<GameObject> pool = new Stack<GameObject>(); //ooooooh lifo. stack. //last thing you put is first thing you get out of it 
    //protected means its private but the sub-classes can access it 
    
    public GameObject Get() //function that gets the game obj 
    {
        GameObject result; // var for gameobj 

        if (pool.Count == 0) //if the pool is empty...
        {
            result = GetNewObject(); //create a new object
        } else { //OTHERWISE
            result = pool.Pop(); //get the top obj out of the stack

            print("Num Objects:  "  + transform.childCount + " Pool Size: " + pool.Count); //print this info 
        }

        result.transform.parent = this.transform; //parent the object under the gameobj w/ the pool

        result.SetActive(true); //turn object on!
        //we need to turn this on bc we are recycling. meaning theres a chance it can be off 
        return result; //return the object
    }

    protected abstract GameObject GetNewObject(); //abstract function, all children must implement this or be subclasses
    //protected sub-classes can see it. ANYTHING that extends from this abstract class (unless its also abstract) must implement this function 
    
    public void Push(GameObject used){ //put gameobj in pool 
        used.SetActive(false); //turn off gameobj 
        pool.Push(used); //put it on top of the stack so it can be recycled
    }

}
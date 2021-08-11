﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Extends abstract ObjectPool
public class PewPool : ObjectPool
{
    public GameObject pew; //Type of gameObject for this pool

    public static PewPool instance; //holds singleton reference

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

        //insert 3 bullets into pool
        //this class will allow a mixmum of 3 bullets at once
        Push(GetNewObject());
        Push(GetNewObject());
        Push(GetNewObject());
    }

    //ovveride abstract method, make it return a new bullet
    protected override GameObject GetNewObject()
    {
        return Instantiate<GameObject>(pew);
    }

    //wrapper around "Get" from base, sets up bullet to be used again
    public GameObject GetPew()
    {
        if(pool.Count == 0){ //if there's nothing in the pool
            return null; //don't make a new bullet
        } else { //otherwise
            GameObject pew = Get(); //get a bullet out

            pew.GetComponent<PewScript>().Reset(); //reset it

            return pew; //return it
        }
    }
}
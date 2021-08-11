using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random; //is this what im supposed to be using? is this causing the problem 

public class SugarScript : MonoBehaviour
{
    public GameObject slobber; //prefab for slobber

    public Transform[] spawnPoints; //array where you spawn sugar 
    public GameObject[] sugars; //multiple sugar gameobjs
    int randomSpawnPoint, randomSugar; //int variables
    public static bool spawnAllowed; //allows us to instantiate sugar only if mickey is still there

    //public float intervalMin = 0.1f; //min time to spawn the slobber
    //public float intervalMax = 0.3f; //max time to span new slobber?

    // Start is called before the first frame update
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnSugar", 0f, 1f); //instantiate sugar every 1 sec by invoking spawn sugar 
        InvokeRepeating("Slobber", 2, 2); //call slobber every sec
        //InvokeRepeating("Slobber", intervalMin, intervalMax); //callSlobber after intervalMin time 
    }
    void SpawnSugar()
    {
        if (spawnAllowed) { //if allowed 
            randomSpawnPoint = Random.Range(0, spawnPoints.Length); //a random spawn point is calculated from 0 to length
            randomSugar = Random.Range(0, sugars.Length); //a random sugar is calucluated from 0 to length 
            Instantiate(sugars[randomSugar], spawnPoints[randomSpawnPoint].position, Quaternion.identity); //a new sugar is spawned at some random pos 
        }   
    }

    void Slobber()
    {
        Instantiate<GameObject>(slobber, transform.position, Quaternion.identity);
        //^^quaternion.identity - keeps the current rotation of the gameobject
        //create a new slobber prefab lol
    }
}
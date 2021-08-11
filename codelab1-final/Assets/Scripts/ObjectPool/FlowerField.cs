using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerField : MonoBehaviour
{
    public float intervalMin = 0.1f; //minimum amnt of time to spawn a new flower
    public float intervalMax = 0.5f; //max time to spawn a new flower
    public float numFlowers = 10; //how many flower to span at once????

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnFlower", intervalMin); //call SpawnFlower after the intervalMin time
    }

    void SpawnFlower()
    {
        //generate numFlowers flowers
        for (int i = 0; i < numFlowers; i++){
            GameObject flower = FlowerPool.instance.GetFlower();
        }

        //call SpawnFlower again after some time
        Invoke("SpawnFlower", Random.Range(intervalMin, intervalMax));
    }
}
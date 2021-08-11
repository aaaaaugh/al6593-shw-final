using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactMunch : MonoBehaviour
{
    AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        source.Play();
        
        print("munchie munch munch munch munch munch"); //shows up on console
    }

}
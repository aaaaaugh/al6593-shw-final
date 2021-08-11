using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAttack : MonoBehaviour
{
    public GameObject pewPrefab;
    
    public virtual void Attack()
    {
        Vector2 currentPos = transform.position;
        currentPos.y += 1f;
        
        SpawnPew(currentPos);
    }

    public virtual void SpawnPew(Vector2 currentPos)
    {
        GameObject bullet = Instantiate<GameObject>(pewPrefab);

        bullet.GetComponent<Rigidbody2D>().gravityScale = -1;
        
        bullet.transform.position = currentPos;
    }
}
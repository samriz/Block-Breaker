using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision) //engine will call this when ball hits block
    {
        Destroy(gameObject); //destroy block when something collides with it
        Debug.Log(collision.gameObject.name); 
    }
}

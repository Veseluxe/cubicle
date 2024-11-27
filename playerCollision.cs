using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement movement;
    void OnCollisionEnter(Collision collisioninfo )
    {
       if(collisioninfo.collider.tag=="obstacle")
       {
         movement.enabled = false;
         FindObjectOfType<GameManager>().EndGame();  
       }
    }
    
}

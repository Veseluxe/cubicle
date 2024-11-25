
using UnityEngine;

public class playercollision : MonoBehaviour
{
    public playermovement movement;
    public Gamemanager gamemanager;
    void OnCollisionEnter (Collision collisioninfo)
    {
        if (collisioninfo.collider.tag =="obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<Gamemanager>().gameover(); 
        }

    }
        
   
}

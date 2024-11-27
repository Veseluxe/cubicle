using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //this is a refrence to the rigidbody component used in the unity called rb
    public Rigidbody rb;

    public float forwardForce=200f;
    public float sideForce=500f;

    //we marked this as fixed update because we wanted to mess with the physics of the player in the game
    void FixedUpdate()
    {
      rb.AddForce(0,0,forwardForce*Time.deltaTime);//adding a force of  forward force in the z axis
      if(Input.GetKey("d"))
      {
         rb.AddForce(sideForce*Time.deltaTime,0,0,ForceMode.VelocityChange);//force has modes so buttons dont feel unresponsive and velocity can be changed in a nice and efficient way   
      }
      if(Input.GetKey("a"))
      {
        rb.AddForce(-sideForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
      } 
      if(rb.position.y<-1f)
      {
         FindObjectOfType<GameManager>().EndGame(); 
      }
    }

}

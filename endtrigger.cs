using UnityEngine;

public class endtrigger : MonoBehaviour
{
    public Gamemanager gamemanager;
   void OnTriggerEnter()
   {
         gamemanager.Completelevel();
   }

  

  
}

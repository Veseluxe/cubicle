 using UnityEngine;
using UnityEngine.SceneManagement;
public class Gamemanager : MonoBehaviour
{
    public float restartdelay =1f;
    public GameObject completelevelUI;
    public void Completelevel(){
        completelevelUI.SetActive(true);
    } 
    bool gamehasended = false;
   public void gameover()

   {
    if (gamehasended==false)
    {
      gamehasended=true;
     Debug.Log("GAME OVER!");
     Invoke("restart",restartdelay);
    }
     
   }

   void restart()
   {
     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}



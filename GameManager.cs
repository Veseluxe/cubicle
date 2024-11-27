using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool GameHasEnded=false; 
    public float restartDelay=1f;

    public GameObject completelevelUI;

    public void LevelCompleted()
    {
      completelevelUI.SetActive(true);  
    }
    public void EndGame()
    {
        
       if (GameHasEnded==false)
       {
         GameHasEnded=true;
         Debug.Log("GAME OVER");
         Invoke("Restart",restartDelay); //the purpose of invoke function is that 
                                         //once the block has collided it will give a specific amount of delay time to reset the block to its original position 
       }
    }
    void Restart()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = 2f;
    public GameObject DeathUI;
    public Spawner[] spawner;


    

    public void Death()
    {
        DeathUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            for (int i = 0; i < spawner.Length; i++)
            {
                spawner[i].enabled = false;
            }
            
                        
            //Invoke("Restart", restartDelay);
        }
        

    }

    /*void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }*/
}

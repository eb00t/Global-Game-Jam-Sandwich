using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

   public void QuitGame()
    {
        Debug.Log ("Quit Game!");

        Application.Quit();
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene(0);
    }
}

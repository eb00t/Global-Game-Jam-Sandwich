using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    private MusicPlayer MusicPlayer;
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
        MusicPlayer.KILLMYASS();
        SceneManager.LoadScene(0);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

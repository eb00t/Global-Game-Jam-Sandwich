using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controlLvl : MonoBehaviour
{

    public Button Level1, Level2;

    private int lvlPassed;
    // Start is called before the first frame update
    void Start()
    {
        lvlPassed = PlayerPrefs.GetInt("lvlPassed");
        Level1.interactable = false;
        Level2.interactable = false;

        switch (lvlPassed)
        {
            case 1:
                Level1.interactable = true;
                break;
            case 2:
                Level2.interactable = true;
                break;
        }
    }

    public void LoadZeLvl(int Levels)
    {
        SceneManager.LoadScene(Levels);
    }

    public void resetPP()
    {
        Level1.interactable = false;
        Level2.interactable = false;
        
        PlayerPrefs.DeleteAll();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

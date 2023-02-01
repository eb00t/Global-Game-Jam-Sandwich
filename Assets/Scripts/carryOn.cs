using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class carryOn : MonoBehaviour
{
    public static carryOn instance = null;
    public GameObject retry, GoodJob;
    public int sceneIndex, lvlPassed;
    
    // Start is called before the first frame update
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        lvlPassed = PlayerPrefs.GetInt("lvlPassed");
    }

    public void OnMouseDown()
    {
        if (lvlPassed < sceneIndex)
        {
            PlayerPrefs.SetInt("lvlPassed", sceneIndex);
        }
        
    }

    public void LoadTheNext()
    {
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

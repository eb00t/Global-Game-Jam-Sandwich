using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public GameObject Lemon, Bonsai, Orchid, Rose, Tomato;
    public GameObject LemonSwitch,BonsaiSwitch, OrchidSwitch, RoseSwitch, TomatoSwitch;
    public static bool lemonCheck, bonsaiCheck, orchidCheck, roseCheck, tomatoCheck;
    public GameObject menu;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        if (lemonCheck == true)
        {
            Lemon.SetActive(false);
            LemonSwitch.SetActive(true);
        }

        if (bonsaiCheck == true)
        {
            Bonsai.SetActive(false);
            BonsaiSwitch.SetActive(true);
        }

        if (orchidCheck == true)
        {
            Orchid.SetActive(false);
            OrchidSwitch.SetActive(true);
        }

        if (roseCheck == true)
        {
            Rose.SetActive(false);
            RoseSwitch.SetActive(true);
        }

        if (tomatoCheck == true)
        {
            Tomato.SetActive(false);
            TomatoSwitch.SetActive(true);
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.CompareTag("ClickSprite"))
                {
                    if (hit.collider.gameObject == Lemon)
                    {
                        lemonCheck = true;
                        SceneManager.LoadScene(6);
                    }

                    else if (hit.collider.gameObject == Bonsai)
                    {
                        bonsaiCheck = true;
                        SceneManager.LoadScene(5);
                    }

                    else if (hit.collider.gameObject == Orchid)
                    {
                        orchidCheck = true;
                        SceneManager.LoadScene(7);
                    }

                    else if (hit.collider.gameObject == Rose)
                    {
                        roseCheck = true;
                        SceneManager.LoadScene(8);
                    }

                    else if (hit.collider.gameObject == Tomato)
                    {
                        tomatoCheck = true;
                        SceneManager.LoadScene(9);
                    }
                }
            }
        }
    }
}


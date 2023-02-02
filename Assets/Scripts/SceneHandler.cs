using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public GameObject Lemon, Bonsai, Orchid, Rose, Tomato;
    public GameObject LemonSwitch,BonsaiSwitch, OrchidSwitch, RoseSwitch, TomatoSwitch;
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
                        Lemon.SetActive(false);
                        SceneManager.LoadScene(6);
                        LemonSwitch.SetActive(true);
                    }

                    else if (hit.collider.gameObject == Bonsai)
                    {
                        Bonsai.SetActive(false);
                        SceneManager.LoadScene(5);
                        BonsaiSwitch.SetActive(true);
                    }

                    else if (hit.collider.gameObject == Orchid)
                    {
                        Orchid.SetActive(false);
                        SceneManager.LoadScene(7);
                        OrchidSwitch.SetActive(true);
                    }

                    else if (hit.collider.gameObject == Rose)
                    {
                        Rose.SetActive(false);
                        SceneManager.LoadScene(8);
                        RoseSwitch.SetActive(true);
                    }

                    else if (hit.collider.gameObject == Tomato)
                    {
                        Tomato.SetActive(false);
                        SceneManager.LoadScene(9);
                        TomatoSwitch.SetActive(true);
                    }
                }
            }
        }
    }
}


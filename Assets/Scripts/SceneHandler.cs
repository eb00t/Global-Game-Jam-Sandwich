using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public GameObject Lemon, Bonsai, Orchid, Rose, Tomato;

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
                        SceneManager.LoadScene(6);
                    }

                    else if (hit.collider.gameObject == Bonsai)
                    {
                        SceneManager.LoadScene(5);
                    }

                    else if (hit.collider.gameObject == Orchid)
                    {
                        SceneManager.LoadScene(7);
                    }

                    else if (hit.collider.gameObject == Rose)
                    {
                        SceneManager.LoadScene(8);
                    }

                    else if (hit.collider.gameObject == Tomato)
                    {
                        SceneManager.LoadScene(9);
                    }
                }
            }
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToothTracker : MonoBehaviour
{
    public static int teethCollected;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.CompareTag("Tooth"))
                {
                    teethCollected++;
                    print(teethCollected);
                    BoxCollider2D col = hit.collider.gameObject.GetComponent<BoxCollider2D>();
                    SpriteRenderer ren = hit.collider.gameObject.GetComponent<SpriteRenderer>();
                    AudioSource aud = hit.collider.gameObject.GetComponent<AudioSource>();
                    col.enabled = false;
                    ren.enabled = false;
                    aud.Play();
                    
                    //hit.collider.gameObject.SetActive(false);
                }
            }
        }
    }
}

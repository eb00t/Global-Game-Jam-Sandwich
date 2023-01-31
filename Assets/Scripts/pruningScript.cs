using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruningScript : MonoBehaviour
{
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.0f;
       
        //Rigidbody2D rb = GameObject.Find("behead").GetComponent<Rigidbody2D>();
    }

    public void OnMouseDown() 
     {
         if (gameObject.CompareTag("behead"))
         {
             rb.gravityScale = 1f;
         }
         else
         {
             rb.gravityScale = 0.0f;
         }
         
     }
    
}

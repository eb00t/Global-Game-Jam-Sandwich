using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruningScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private float thrust = 5f;
    
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
             rb.AddForce(transform.up * thrust, ForceMode2D.Impulse);
         }
         
         if (gameObject.CompareTag("stay"))
         {
             rb.gravityScale = 1f;
             rb.AddForce(transform.up * thrust, ForceMode2D.Impulse);
         }
     }
    
}

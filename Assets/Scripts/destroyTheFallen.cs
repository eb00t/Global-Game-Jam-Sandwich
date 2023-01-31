using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyTheFallen : MonoBehaviour
{
    //public Transform live;
    
    public int dontDestroy = 2;
    public int staticNumber = 2;

    public GameObject nextLvl;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("behead"))
        {
            Destroy(col.gameObject);
        }

        if (col.gameObject.CompareTag("stay"))
        {
            dontDestroy --;

            if (dontDestroy == staticNumber)
            {
                nextLvl.SetActive(true);
            }

            else
            {
                nextLvl.SetActive(false);
            }
            Destroy(col.gameObject);
        }
    }
}

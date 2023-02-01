using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class destroyTheFallen : MonoBehaviour
{
    //public Transform live;
    
    public int dontDestroy = 2;
    public int staticNumber = 2;
    public int badOnes = 4;
    public int fuckinLoser = 6;

    public GameObject nextLvl;


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("behead"))
        {
            badOnes--;
            Destroy(col.gameObject);
            fuckinLoser--;
        }

        if (col.gameObject.CompareTag("stay"))
        {
            dontDestroy --;
            Destroy(col.gameObject);
            fuckinLoser--;
        }
        
        if (badOnes <= 0 && dontDestroy == staticNumber)
        {
            nextLvl.SetActive(true);
        }

        if (fuckinLoser ==1)
        {
            Debug.Log("u lose");
        }
        
        
    }
}

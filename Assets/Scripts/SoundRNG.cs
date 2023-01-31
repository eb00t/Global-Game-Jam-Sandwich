using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundRNG : MonoBehaviour
{
    public AudioSource Sound1, Sound2, Sound3;
    public int rnd;

    public void RandomSound()
    {
        
   rnd = Random.Range(1,3);
  switch (rnd)
    {
       case 1:
       Sound1.Play();
        break; 
       
       case 2: 
           Sound2.Play();
           break;
       
       case 3:
           Sound3.Play();
           break;
       
       default:
           Sound1.Play();
           break;
    }
    
    }
    
}

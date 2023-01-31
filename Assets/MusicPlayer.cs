using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private static MusicPlayer ButtonAudio;
    void Start()
    {
    
        DontDestroyOnLoad(this);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

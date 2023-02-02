using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Volume : MonoBehaviour
{
    public AudioMixer masterMixer;

        public void SetSound(float soundLevel)
        {
            masterMixer.SetFloat("masterVolume", soundLevel);
        }
    }


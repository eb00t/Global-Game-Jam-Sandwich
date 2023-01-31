using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SceneTimer : MonoBehaviour
{
    public float timeTotal;
    public float step;
    public float log;

    public bool timerRunning = false;

    public TextMeshProUGUI timer;

    void Update()
    {
        if (timerRunning == true && timeTotal >= 0)
        {
            print(Time.time);
            if (Time.time >= log + step)
            {
                log = Time.time;
                timeTotal -= step;
                string time = Mathf.RoundToInt(timeTotal).ToString();
                timer.text = time;
            }
        }
    }

    public void ToggleTimer()
    {
        if (timerRunning == false)
        {
            timerRunning = true;
        }
        else if (timerRunning == true)
        {
            timerRunning = false;
        }
    }
}
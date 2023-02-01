using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    private Slider slider;
    private float log, increase;
    private float step = .4f;
    public GameObject plant1, plant2, plant3;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponentInChildren<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        increase = Random.Range(0.05f, .2f);

        if (Time.time >= log + step)
        {
            log = Time.time;
            slider.value += increase;

            if (plant1.activeSelf)
            {
                plant1.SetActive(false);
                plant2.SetActive(true);
            }
            else if (plant2.activeSelf)
            {
                plant2.SetActive(false);
                plant3.SetActive(true);
            }
            else if (plant3.activeSelf)
            {
                plant3.SetActive(false);
                plant1.SetActive(true);
            }
        }

        if (slider.value == slider.maxValue)
        {
            gameObject.SetActive(false);
        }
    }
}

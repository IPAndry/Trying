﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] private Slider speedSlider;

    // Start is called before the first frame update
    void Start()
    {
        speedSlider.value = PlayerPrefs.GetFloat("speed", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public void OnSubmitName(string name)
    {
        print(name);
    }

    public void OnSpeedValue(float speed)
    {
        print("SPed " + speed);
        PlayerPrefs.SetFloat("speed", speed);
    }
}

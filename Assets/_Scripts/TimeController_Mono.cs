using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController_Mono : MonoBehaviour
{
    public float TimeScale = 1;
    
    private void Start()
    {
        Time.timeScale = TimeScale;
    }

    private void Update()
    {
        HandleInputs();
    }

    private void HandleInputs()
    {
        if (Input.GetKeyDown(KeyCode.Minus))
        {
            ChangeTimeScale(-0.1f);
        }

        if (Input.GetKeyDown(KeyCode.Equals))
        {
            ChangeTimeScale(0.1f);
        }
    }

    private void ChangeTimeScale(float timeScaleIncrement)
    {
        TimeScale += timeScaleIncrement;
        Debug.Log("SETTING TIMESCALE TO " + TimeScale);
    }
}

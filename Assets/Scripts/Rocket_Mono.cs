using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket_Mono : MonoBehaviour
{
    
    public Rigidbody _carRB;
    private bool _isBoosting;


    public float BoostStrength = 1;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            ToggleBoost(true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            ToggleBoost(false);
        }
        
        
        if (_isBoosting)
        {
            _carRB.AddForce(transform.forward * BoostStrength, ForceMode.Impulse);
        }
    }

    private void ToggleBoost(bool b)
    {
        _isBoosting = b; 
    }
}

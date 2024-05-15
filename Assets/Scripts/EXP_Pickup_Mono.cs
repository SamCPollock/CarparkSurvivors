using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXP_Pickup_Mono : MonoBehaviour
{

    public int EXPValue;
    
    public void Initialize(int value)
    {
        EXPValue = value;
        transform.localScale = transform.localScale * value;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ///Get picked up
            BeCollected();
        }
    }

    private void BeCollected()
    {
        Destroy(gameObject);
    }
}

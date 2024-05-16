using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThatSpecificGuyKiller_Mono : MonoBehaviour
{

    public GameObject thatSpecificGuy;

    public Hammer_Mono thatSpecificHammer;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            KillThatGuy();
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            SpeedUpTheHammer();
        }
    }


    private void KillThatGuy()
    {
        Destroy(thatSpecificGuy);
    }

    private void SpeedUpTheHammer()
    {
        thatSpecificHammer.currentSpeed = thatSpecificHammer.currentSpeed + 100;
    }
}

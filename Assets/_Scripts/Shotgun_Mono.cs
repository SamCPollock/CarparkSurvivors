using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun_Mono : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    ///When colliding with an enemey
    ///do damage
    private void OnTriggerEnter(Collider other)
    {
        ///other.GetComponent<Enemy_Mono>
        Debug.Log("something hit me");
        Destroy(other.gameObject);
    }

}

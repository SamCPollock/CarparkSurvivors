using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InvisibleBooster_Mono : MonoBehaviour
{

    private Rigidbody _rb;
    [SerializeField] private float accelerationCutoff; 
    [SerializeField] private float forceMultiplier; 
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            HandleBoost();
        }
    }

    private void HandleBoost()
    {
        if (_rb.velocity.magnitude <= accelerationCutoff)
        {
            Debug.Log("VELOCITY = " + _rb.velocity.magnitude);
            _rb.AddRelativeForce(Vector3.forward * forceMultiplier, ForceMode.Impulse);
        }
    }
}

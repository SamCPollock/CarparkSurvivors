using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ram_Mono : MonoBehaviour
{
    public int damage = 1;
    public float forceMagnitude = 10.0f;
    
    private void OnTriggerEnter(Collider other)
    {
        Enemy_Mono collidedEnemy = other.GetComponent<Enemy_Mono>();
        if (collidedEnemy != null)
        {
            collidedEnemy.TakeDamage(damage);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Get the Rigidbody component of the object we collided with
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();

        // If the collided object has a Rigidbody, apply the force
        if (rb != null)
        {
            // Calculate direction away from the impact point
            Vector3 forceDirection = collision.transform.position - transform.position;
            forceDirection.Normalize();

            // Apply the force
            rb.AddForce(forceDirection * forceMagnitude, ForceMode.Impulse);
        }
    }


    /*
    ///When hitting an enemy
    ///Do damage
    private void OnCollisionEnter(Collision other)
    {
        Enemy_Mono collidedEnemy = other.GetComponent<Enemy_Mono>();
        if (collidedEnemy != null)
        {
            other.GetComponent<Enemy_Mono>().TakeDamage(damage);
        }
    }
    */
}

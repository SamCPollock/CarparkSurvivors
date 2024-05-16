using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter_Mono : MonoBehaviour
{

    public float shotDelay;
    public GameObject shotPrefab;
    public Transform spawnLocation; 
    
    private float _timeSinceLastShot; 

    private void Update()
    {
        ///SHOT TIMER
        ShotTimer();
    }

    private void ShotTimer()
    {
        _timeSinceLastShot += Time.deltaTime;

        if (_timeSinceLastShot >= shotDelay)
        {
            Shoot();
            _timeSinceLastShot = 0;
        }
        
    }

    private void Shoot()
    {
        GameObject spawnedProjectile = GameObject.Instantiate(shotPrefab, spawnLocation.position, transform.rotation);
        // spawnedProjectile.GetComponent<Projectile_Mono>().Initialize(transform.forward);
    }
}

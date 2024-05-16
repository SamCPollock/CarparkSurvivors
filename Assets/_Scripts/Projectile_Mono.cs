using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Mono : MonoBehaviour
{
    public float speed;
    public float lifespan = 5;
    public int damage = 1;

    private float _lifetime;
    void Start()
    {
        
    }

    void Update()
    {
        /// Fly forwards
        /// Delete after some time
        /// detect hitting enemies
        FlyForwards();
        HandleLifespan();
    }

    public void Initialize(Vector3 forward)
    {
        transform.LookAt(forward);
    }
    
    private void FlyForwards()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void HandleLifespan()
    {
        _lifetime += Time.deltaTime;

        if (_lifetime > lifespan)
        {
            DestroyBullet();
        }
    }
    
    private void DestroyBullet()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        IDamageable hitOther = other.GetComponent<IDamageable>();

        if (hitOther != null)
        {
            hitOther.TakeDamage(damage);
            DestroyBullet();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Mono : MonoBehaviour, IDamageable
{
   private GameObject _target;

   public GameObject EXPPrefab; 
   public float Speed;
   public int EXPValue = 1;

   public int Health = 1;
   private Rigidbody _rb;
   
   private void Start()
   {
      _target = GameObject.FindGameObjectWithTag("Player");
      _rb = gameObject.GetComponent<Rigidbody>();
   }

   private void FixedUpdate()
   {
      /// Movetowards target
      MoveTowardsTarget();
   }


   private void MoveTowardsTarget()
   {
      Vector3 direction = _target.transform.position - transform.position;
      direction.Normalize();
      _rb.MovePosition(transform.position + direction * Speed);
   }

   public void TakeDamage(int damage)
   {
      Health -= damage;
      if (Health <= 0)
      {
         Die();
      }
   }


   public void Die()
   {
      EXP_Pickup_Mono instantiatedEXP = Instantiate(EXPPrefab, transform.position, transform.rotation).GetComponent<EXP_Pickup_Mono>();
      instantiatedEXP.Initialize(EXPValue);
      
      Destroy(gameObject);
   }
}

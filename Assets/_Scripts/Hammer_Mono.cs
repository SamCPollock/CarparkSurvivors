using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer_Mono : MonoBehaviour
{
    public int damage = 1;
    public float currentSpeed = 360;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /// Complete 1 full spin per 2 seconds
        Spin(currentSpeed);
    }

    /// When colliding with an enemey
    /// do damage
    private void OnTriggerEnter(Collider other)
    {
        Enemy_Mono collidedEnemy = other.GetComponent<Enemy_Mono>();
        if (collidedEnemy != null)
        {
            other.GetComponent<Enemy_Mono>().TakeDamage(damage);
        }
    }

    private void Spin(float speed)
    {
        transform.Rotate(new Vector3(speed * Time.deltaTime, 0, 0));
    }

}

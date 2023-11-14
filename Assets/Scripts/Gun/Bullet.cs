using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 10f;
    public float initialForce = 10f;
    public float forceIncreaseRate = 2f;
    public float maxForce = 20f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.CompareTag("Enemy"))
        {
           
            EnemyHealth enemyHealth = collision.collider.GetComponent<EnemyHealth>();

            
            if (enemyHealth != null)
            {
                
                enemyHealth.TakeDamage(damage);

                
                Destroy(gameObject);
            }
        }
    }
}


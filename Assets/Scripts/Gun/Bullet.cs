using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 10f;
    public float initialForce = 10f;
    public float forceIncreaseRate = 2f;
    public float maxForce = 20f;

    public string enemyTag = "Enemy";


    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag(enemyTag))
        {
            
            Destroy(collision.gameObject);

           
            Destroy(gameObject);
        }
    }
}


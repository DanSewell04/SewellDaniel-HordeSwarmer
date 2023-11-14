using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyController : MonoBehaviour
{
    public float speed = 5f; 
    public float maxHealth = 100f; 

    private float currentHealth;

    private Transform player;

    void Start()
    {
        
        player = GameObject.FindGameObjectWithTag("Player").transform;

        if (player == null)
        {
            Debug.LogError("Player not found! Make sure the player has the tag 'Player'.");
        }

        currentHealth = maxHealth;
    }

    void Update()
    {
     
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }

    public void TakeDamage(float damage)
    {
        
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                playerHealth.TakeDamage(maxHealth); 
            }
        }
    }
}


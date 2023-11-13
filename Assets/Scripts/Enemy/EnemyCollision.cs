using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public int damageAmount = 10; // Adjust the amount of damage as needed

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Check if the colliding object has the tag "Player"
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                // Deduct health from the player
                playerHealth.TakeDamage(damageAmount);
            }
        }
    }
}


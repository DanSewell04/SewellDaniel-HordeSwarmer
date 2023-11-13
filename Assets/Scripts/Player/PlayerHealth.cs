using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        // Add any additional logic for health-related effects or checks here

        if (currentHealth <= 0)
        {
            // Player is defeated or game over logic here
            Debug.Log("Player defeated!");
        }
    }
}


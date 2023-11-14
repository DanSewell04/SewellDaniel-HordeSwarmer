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

        if(maxHealth < 0)
        {
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Player took damage. Current health: " + currentHealth);

        }
    }

}


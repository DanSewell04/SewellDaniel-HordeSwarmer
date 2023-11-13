using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove: MonoBehaviour
{
    public float speed = 3f; // Adjust the speed of the enemy as needed
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        if (player == null)
        {
            Debug.LogError("Player not found! Make sure the player has the tag 'Player'.");
        }
    }

    void Update()
    {
        if (player != null)
        {
            
            transform.LookAt(player);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}



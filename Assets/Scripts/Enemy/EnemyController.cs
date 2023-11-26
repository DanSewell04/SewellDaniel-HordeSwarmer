using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyController : MonoBehaviour
{
    public float speed = 5f;
    public float maxHealth = 100f;

    private float currentHealth;
    public int damageAmount = 10;

    private Transform player;
    public Transform respawnPoint;

    private Quaternion initialRotation;


    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").transform;

        if (player == null)
        {
            Debug.LogError("Player not found! Make sure the player has the tag 'Player'.");
        }

        currentHealth = maxHealth;
        initialRotation = transform.rotation;
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

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
           
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();

            
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount);
            }
        }

        void RespawnEnemy(float respawnDelay)
        {

            Instantiate(gameObject, respawnPoint.position, respawnPoint.rotation);
            transform.position = respawnPoint.position;
            gameObject.SetActive(true);



        }


        void EnableCollider()
        {
            GetComponent<Collider>().enabled = true;
        }
    } }




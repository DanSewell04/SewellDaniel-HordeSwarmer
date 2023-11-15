using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnPoint;
    public float respawnTime = 5f;

    void Start()
    {

        StartCoroutine(RespawnEnemy());
    }

    IEnumerator RespawnEnemy()
    {
        while (true)  // Infinite loop for continuous respawning
        {
            yield return new WaitForSeconds(respawnTime);

            
            GameObject newEnemy = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);

           
        }
    }
}



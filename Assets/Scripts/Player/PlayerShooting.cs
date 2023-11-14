using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float fireRate = 0.1f;
    public float bulletForce;
    private float nextFireTime;

    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time > nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

        
        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawnPoint.up * bulletForce, ForceMode.Impulse);

        
        Destroy(bullet, 3f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooting : MonoBehaviour
{
    public GameObject bulletPrefab;  // Bullet prefab reference
    public Transform bulletSpawnPoint;  // Where the bullet will spawn (in front of the tank)
    public float shootingRate = 1f;  // Time between shots (e.g., 1 bullet per second)

    private float shootingTimer;

    void Update()
    {
        shootingTimer += Time.deltaTime;

        if (shootingTimer >= shootingRate)
        {
            Shoot();
            shootingTimer = 0f;  // Reset the timer after shooting
        }
    }

    void Shoot()
    {
        // Add a 90-degree rotation to the bullet
        Quaternion bulletRotation = bulletSpawnPoint.rotation * Quaternion.Euler(0, 0, 90);

        // Instantiate the bullet at the spawn point's position with the modified rotation
        Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletRotation);
    }
}

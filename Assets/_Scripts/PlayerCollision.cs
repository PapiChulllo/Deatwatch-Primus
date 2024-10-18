using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the player collides with an enemy
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Access the HealthManager and reduce the player's health
            FindObjectOfType<HealthManager>().TakeDamage();

            // Optionally, destroy the enemy upon collision
            Destroy(collision.gameObject);
        }
    }
}

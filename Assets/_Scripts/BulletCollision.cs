using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the bullet collides with an enemy
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Add 10 points to the score
            ScoreManager.AddScore(10);

            // Destroy the enemy
            Destroy(collision.gameObject);

            // Destroy the bullet as well
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    public AudioClip explosionSound;  // Explosion sound clip for when the enemy is destroyed
    public int scoreValue = 10;  // The score the player gets for destroying an enemy

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the bullet collides with an enemy
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Play the explosion sound at the enemy's position
            AudioSource.PlayClipAtPoint(explosionSound, collision.transform.position);

            // Add score to the player when the enemy is destroyed
            ScoreManager.AddScore(scoreValue);

            // Destroy the enemy immediately
            Destroy(collision.gameObject);

            // Destroy the bullet
            Destroy(gameObject);
        }
    }
}

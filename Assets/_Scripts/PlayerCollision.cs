using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public AudioClip explosionSound;  // Explosion sound clip
    private AudioSource audioSource;  // Reference to the AudioSource component

    void Start()
    {
        audioSource = GetComponent<AudioSource>();  // Get the AudioSource component
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the player collides with an enemy
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Play explosion sound
            audioSource.PlayOneShot(explosionSound);

            // Access the HealthManager to reduce player's health
            FindObjectOfType<HealthManager>().TakeDamage();

            // Destroy the enemy
            Destroy(collision.gameObject);
        }
    }
}

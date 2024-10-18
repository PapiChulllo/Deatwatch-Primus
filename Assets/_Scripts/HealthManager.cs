using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int maxHealth = 3;  // Maximum number of hearts (lives)
    private int currentHealth;  // Current number of lives

    public Image[] hearts;  // Array to hold the heart images
    public Sprite fullHeart;  // Sprite for a full heart
    public Sprite emptyHeart;  // Sprite for an empty heart

    void Start()
    {
        currentHealth = maxHealth;  // Initialize player with max health
        UpdateHearts();
    }

    // This function is called when the player takes damage (collides with an enemy)
    public void TakeDamage()
    {
        if (currentHealth > 0)
        {
            currentHealth--;  // Reduce health by 1
            UpdateHearts();  // Update the heart icons
        }

        if (currentHealth <= 0)
        {
            GameOver();  // Call game over when no hearts remain
        }
    }

    // This function updates the heart images based on the current health
    void UpdateHearts()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < currentHealth)
            {
                hearts[i].sprite = fullHeart;  // Show full hearts
            }
            else
            {
                hearts[i].sprite = emptyHeart;  // Show empty hearts
            }
        }
    }

    // Game over logic
    void GameOver()
    {
        Debug.Log("Game Over!");  // You can add game over logic here (e.g., restart game, show game over screen)
    }
}

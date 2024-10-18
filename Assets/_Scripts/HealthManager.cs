using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;  // Import TextMeshPro namespace
using UnityEngine.SceneManagement;  // For switching scenes

public class HealthManager : MonoBehaviour
{
    public int maxHealth = 3;  // Maximum number of hearts (lives)
    private int currentHealth;  // Current number of lives

    public Image[] hearts;  // Array to hold the heart images
    public Sprite fullHeart;  // Sprite for a full heart
    public Sprite emptyHeart;  // Sprite for an empty heart

    public GameObject gameOverPanel;  // Reference to the Game Over UI panel
    public TMP_Text gameOverText;     // Reference to the Game Over text

    void Start()
    {
        // Initialize player health to maximum health at the start
        currentHealth = maxHealth;
        UpdateHearts();

        // Ensure the Game Over panel is hidden at the start
        gameOverPanel.SetActive(false);
    }

    // This function is called when the player takes damage (e.g., collides with an enemy)
    public void TakeDamage()
    {
        if (currentHealth > 0)
        {
            currentHealth--;  // Reduce health by 1
            UpdateHearts();   // Update the heart icons
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
        Debug.Log("Game Over!");  // Log the game over state
        gameOverPanel.SetActive(true);  // Show the Game Over panel
        Time.timeScale = 0;  // Pause the game
    }

    // Function to return to the main menu
    public void GoToMainMenu()
    {
        Time.timeScale = 1;  // Resume game before switching scenes
        SceneManager.LoadScene("MainMenu");  // Load the Main Menu scene
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // Import TextMesh Pro namespace

public class ScoreManager : MonoBehaviour
{
    public static int score;  // Static variable to hold the score
    public TMP_Text scoreText;    // TextMesh Pro text component to display the score

    void Start()
    {
        // Initialize the score
        score = 0;
        UpdateScoreText();
    }

    // This method updates the score by a specific amount
    public static void AddScore(int amount)
    {
        score += amount;
    }

    // This method updates the score text UI
    void Update()
    {
        UpdateScoreText();
    }

    // Updates the score text in the UI
    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}

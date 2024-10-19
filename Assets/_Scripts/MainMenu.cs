using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject instructionsPanel;  // Reference to the Instructions Panel

    // Function to start the game
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");  // Load the gameplay scene
    }

    // Function to open the instructions panel
    public void OpenInstructions()
    {
        instructionsPanel.SetActive(true);  // Show the instructions panel
    }

    // Function to close the instructions panel and return to the main menu
    public void CloseInstructions()
    {
        instructionsPanel.SetActive(false);  // Hide the instructions panel
    }
}

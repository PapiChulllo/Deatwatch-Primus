using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Function to start the game
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");  // Load the gameplay scene
    }

    // Function to quit the game
    public void QuitGame()
    {
        Debug.Log("Quit Game!");  // Log in the editor
        Application.Quit();  // Close the application (won't work in editor)
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;  // Single enemy prefab
    public float spawnRate = 2f;    // Time between each spawn
    public float padding = 0.5f;    // Padding to prevent enemies from spawning partially off-screen

    private float timer;
    private Camera cam;

    void Start()
    {
        // Get a reference to the main camera
        cam = Camera.main;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    void SpawnEnemy()
    {
        // Get the screen boundaries in world space
        Vector2 screenBounds = cam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, cam.transform.position.z));

        // Generate a random X position within the visible area, taking padding into account
        float randomX = Random.Range(screenBounds.x + padding, -screenBounds.x - padding);

        // Spawn the enemy at the top of the screen (just above the visible area)
        Vector2 spawnPosition = new Vector2(randomX, screenBounds.y + padding);

        // Apply a -180 degrees rotation (Quaternion.Euler rotates around the Z-axis for 2D)
        Quaternion rotation = Quaternion.Euler(0, 0, -180);

        // Instantiate the enemy with the -180 degrees rotation
        Instantiate(enemyPrefab, spawnPosition, rotation);
    }
}
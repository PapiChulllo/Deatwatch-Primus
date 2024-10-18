using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletSpeed = 5f;  // Speed of the bullet
    public float lifetime = 3f;     // How long the bullet lasts before being destroyed

    void Start()
    {
        // Destroy the bullet after a certain amount of time to avoid clutter
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        // Move the bullet to the right, which after 90-degree rotation will move up the screen
        transform.Translate(Vector2.right * bulletSpeed * Time.deltaTime);
    }
}

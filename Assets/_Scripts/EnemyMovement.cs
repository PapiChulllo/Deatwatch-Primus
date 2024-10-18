using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 3f; // Speed at which the enemy moves

    void Update()
    {
        // Move the enemy downwards based on its local downward direction
        transform.Translate(Vector2.down * speed * Time.deltaTime, Space.World);

        // If the enemy goes off the screen, destroy it
        if (transform.position.y < -5.5f)
        {
            Destroy(gameObject);
        }
    }
}
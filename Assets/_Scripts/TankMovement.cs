using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the tank movement

    private Vector2 targetPosition;

    void Update()
    {
        HandleTouchInput();
        MoveTank();
    }

    // This function handles touch input
    void HandleTouchInput()
    {
        // Check if there is any touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Convert the touch position to world position
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0; // Ensure the Z axis is 0 for 2D movement

            // Set the target position to the touch position
            targetPosition = new Vector2(touchPosition.x, touchPosition.y);
        }
    }

    // This function moves the tank towards the target position
    void MoveTank()
    {
        // Move the tank towards the target position smoothly
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }
}
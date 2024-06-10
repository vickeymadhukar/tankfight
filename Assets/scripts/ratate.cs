using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ratate : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of tank movement
    public float rotationSpeed = 100f; // Speed of tank rotation
    private float horizontalInput; // Input for horizontal movement
    private float verticalInput; // Input for vertical movement
    private bool isMovementEnabled = true;
    void Update()
    {
        if (isMovementEnabled)
        {
            // Get input for horizontal and vertical movement
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");

            // Rotate the tank based on horizontal input
            transform.Rotate(Vector3.forward, -horizontalInput * rotationSpeed * Time.deltaTime);

            // Move the tank based on vertical input and direction it is facing
            transform.position += transform.right * verticalInput * moveSpeed * Time.deltaTime;
        }

     }

    // Method to enable movement
    public void EnableMovement()
    {
        isMovementEnabled = true;
    }

    // Method to disable movement
    public void DisableMovement()
    {
        isMovementEnabled = false;
    }
}

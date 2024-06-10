using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank2move : MonoBehaviour
{
    public float moveSpeed = 5f; 
    public float rotationSpeed = 100f; 
    private float horizontalInput; 
    private float verticalInput;
    private bool ismove = true;


    void Update()
    {
        if (ismove)
        {

            horizontalInput = Input.GetAxis("Horizontal2");
            verticalInput = Input.GetAxis("Vertical2");


            transform.Rotate(Vector3.forward, -horizontalInput * rotationSpeed * Time.deltaTime);

            transform.position += transform.right * verticalInput * moveSpeed * Time.deltaTime;
        }
    }
    public void EnableMove()
    {
        ismove = true;
    }

    // Method to disable movement
    public void DisableMove()
    {
        ismove = false;
    }
}

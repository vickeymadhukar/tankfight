using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrotation : MonoBehaviour
{
   


    public float rotationSpeed = 30f; // Adjust the rotation speed as needed

    void Update()
    {
        // Rotate the object around its center continuously
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }


}

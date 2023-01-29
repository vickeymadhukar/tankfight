using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circular : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);
        movementDirection.Normalize();

        float Inputmagnitude = Mathf.Clamp01(movementDirection.magnitude);
        transform.Translate(movementDirection * speed * Inputmagnitude * Time.deltaTime);


        if (movementDirection != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotation * Time.deltaTime);
        }

    }
}

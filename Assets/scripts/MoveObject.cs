using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    // Public variable to assign the Rigidbody from the Unity Editor
    public Rigidbody rb;

    // Public variable to control the amount of force applied
    public float moveForce = 10f;

    // This method is called once per frame
    void Update()
    {
        // Apply force every frame based on user input
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * moveForce);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * moveForce);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * moveForce);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * moveForce);
        }
    }
}
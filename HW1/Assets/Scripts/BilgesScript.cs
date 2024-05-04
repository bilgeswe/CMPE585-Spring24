using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilgesScript : MonoBehaviour
{
    // Public variable to adjust the force magnitude in Unity's GUI
    public float forceMagnitude = 10f;

    // Private reference to the Rigidbody component
    private Rigidbody rb;

    void Start()
    {
        // Acquire the Rigidbody component via Unity's GUI by dragging and dropping
        rb = GetComponent<Rigidbody>();

        // Is rigidbody present?
        if (rb == null)
        {
 
            Debug.LogError("Rigidbody component not found! This script requires a Rigidbody component attached to the same GameObject.");
        }
    }

    void FixedUpdate()
    {
        // Is rigidbody present?
        if (rb != null)
        {
            // Apply force to the Rigidbody component every frame
            rb.AddForce(Vector3.up * forceMagnitude, ForceMode.Force);
        }
    }
}




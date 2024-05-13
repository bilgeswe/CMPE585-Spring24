using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorControls : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object is a ball
        if (collision.gameObject.tag == "Balls")
        {
            Destroy(collision.gameObject); // Destroys the ball game object
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public float verticalLimit = 80f; // Limit vertical rotation

    private float horizontalRotation = 0f;
    private float verticalRotation = 0f;

    void Start()
    {
        // Preserve initial rotation
        horizontalRotation = transform.eulerAngles.y;
        verticalRotation = transform.eulerAngles.x;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rotate horizontally
        horizontalRotation += mouseX;

        // Rotate vertically within limits
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -verticalLimit, verticalLimit);

        // Apply rotations
        transform.rotation = Quaternion.Euler(verticalRotation, horizontalRotation, 0f);
    }
}
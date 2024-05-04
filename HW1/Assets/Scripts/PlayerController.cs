using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    // Public variables
    public Camera playerCamera; // Reference to the player's camera
    public float walkSpeedis = 10f; // Movement speed when walking
    public float lookSpeedis = 2f; // Speed of camera rotation
    public float lookXLimitis = 45f; // Limit of camera rotation along the x-axis

    // Private variables
    private Vector3 moveDirection = Vector3.zero; // Movement direction
    private float rotationX = 0; // Current rotation along the x-axis
    public bool canMove = true; // Flag to control player movement
    private CharacterController ControlChar; // Reference to the CharacterController component

    void Start()
    {
        // Get reference to the CharacterController component
        ControlChar = GetComponent<CharacterController>();

        // Lock and hide the cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        #region Handles Movement

        // Calculate movement direction based on player input
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);
        float moveSpeedis = Input.GetAxis("Vertical") * walkSpeedis; // Calculate forward/backward movement speed
        float strafeSpeedis = Input.GetAxis("Horizontal") * walkSpeedis; // Calculate strafing movement speed
        moveDirection = (forward * moveSpeedis) + (right * strafeSpeedis);

        // Apply movement
        ControlChar.Move(moveDirection * Time.deltaTime);

        #endregion

        #region Handles Rotation

        // Rotate the player's camera vertically based on mouse input
        if (canMove)
        {
            rotationX += -Input.GetAxis("Mouse Y") * lookSpeedis;
            rotationX = Mathf.Clamp(rotationX, -lookXLimitis, lookXLimitis);
            playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);

            // Rotate the player horizontally based on mouse input
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeedis, 0);
        }

        #endregion
    }
}

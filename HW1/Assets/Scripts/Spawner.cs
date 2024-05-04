using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn; // The object to spawn
    private bool hasSpawned = false; // Flag to track if an object has already been spawned
    private Vector3 initialPosition; // Initial position of the spawner object

    void Start()
    {
        // Save the initial position of the spawner object
        initialPosition = transform.position;
    }

    void Update()
    {
        // Check if the 'T' key is pressed and an object hasn't been spawned yet
        if (Input.GetKeyDown(KeyCode.T) && Time.timeScale > 0 && !hasSpawned)
        {
            // Spawn the object at the initial position of the spawner object
            Instantiate(objectToSpawn, initialPosition, Quaternion.identity);

            // Set the flag to true to indicate that an object has been spawned
            hasSpawned = true;
        }
    }
}

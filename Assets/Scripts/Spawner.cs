using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn; // Reference to the prefab to be spawned

    void Update()
    {
        // Check if a specific button (e.g., Space key) is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Spawn a new instance of the prefab at the current position
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpawner: MonoBehaviour
{
    public GameObject TrapPrefab;
    private float spawnInterval = 60f;
    private float timer = 0f;
    void Update()
    {
        timer += Time.deltaTime;
    }
    IEnumerator SpawnTrapCoroutine()
    {
        // Initial wait before spawning the first trap
        yield return new WaitForSecondsRealtime(spawnInterval);

        // Continuously spawn traps while spawning is enabled
        while (true)
        {
            // Check if it's time to spawn a trap
            if (timer%spawnInterval==0)
            {
                // Generate a random position and instantiate the trap object
                Vector3 randomPosition = GenerateRandomPosition();
                InstantiateTrap(randomPosition);

                // Reset the timer
                timer = 0f;
            }

            // Wait for the next frame
            yield return null;
        }
    }

    Vector3 GenerateRandomPosition()
    {
        // Define the ranges for X, Y, and Z coordinates
        float xMin = -70.2f;
        float xMax = 147.6f;
        float yInt = 18f;
        float zMin = -147.6f;
        float zMax = 56f;

        // Generate random coordinates
        float randomX = UnityEngine.Random.Range(xMin, xMax);
        float randomY = yInt;
        float randomZ = UnityEngine.Random.Range(zMin, zMax);

        // Create a vector with the random coordinates
        return new Vector3(randomX, randomY, randomZ);
    }
    void InstantiateTrap(Vector3 position)
    {
        // Instantiate the trap object at the specified position with no rotation
        Instantiate(TrapPrefab, position, Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpawner : MonoBehaviour
{
    public GameObject TrapPrefab;
    private float spawnInterval = 7f; // Time interval to spawn traps

    void Start()
    {
        StartCoroutine(SpawnTrapCoroutine());
    }

    IEnumerator SpawnTrapCoroutine()
    {
        while (true) // This creates an endless loop
        {
            Vector3 randomPosition = GenerateRandomPosition();
            InstantiateTrap(randomPosition);
            yield return new WaitForSeconds(spawnInterval); // Wait for the specified interval
        }
    }

    Vector3 GenerateRandomPosition()
    {
        float xMin = -70.2f;
        float xMax = 147.6f;
        float yInt = 18f;
        float zMin = -147.6f;
        float zMax = 56f;

        float randomX = UnityEngine.Random.Range(xMin, xMax);
        float randomY = yInt; // Y is constant in this case
        float randomZ = UnityEngine.Random.Range(zMin, zMax);

        return new Vector3(randomX, randomY, randomZ);
    }

    void InstantiateTrap(Vector3 position)
    {
        Instantiate(TrapPrefab, position, Quaternion.identity);
    }
}
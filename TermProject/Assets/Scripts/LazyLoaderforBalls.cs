using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LazyLoaderforBalls : MonoBehaviour
{
    public GameObject[] objectsToLoad; // Array of prefabs or objects you want to instantiate

    void Start()
    {
        // Call CreateObject with a delay for each object
        Invoke("CreateObject1", 5f);
        Invoke("CreateObject2", 10f);
        Invoke("CreateObject3", 15f);
    }

    void CreateObject1()
    {
        // Instantiate the first object
        Instantiate(objectsToLoad[0], transform.position, Quaternion.identity);
    }

    void CreateObject2()
    {
        // Instantiate the second object
        Instantiate(objectsToLoad[1], transform.position, Quaternion.identity);
    }

    void CreateObject3()
    {
        // Instantiate the third object
        Instantiate(objectsToLoad[2], transform.position, Quaternion.identity);
    }
}

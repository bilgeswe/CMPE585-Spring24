// PickUpKey Script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{
    public bool hasKey = false; // Initialize hasKey to false

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            hasKey = true; // Set hasKey to true when the key is picked up
        }
    }
}

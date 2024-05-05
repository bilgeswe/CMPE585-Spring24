// OpenDoor Script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public PickUpKey pickUpKey;
    public GameObject FinishText;

    void Start()
    {
        FinishText.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (pickUpKey.hasKey) // Check if the player has the key
            {
                FinishText.SetActive(true);
            }
        }
    }
}

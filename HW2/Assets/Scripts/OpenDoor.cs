// OpenDoor Script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    public PickUpKey pickUpKey;
    public string status;
    void Start()
    {
        string status = "LOOSE";
        GameOverScreen.background.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (pickUpKey.hasKey) // Check if the player has the key
            {   
                string status = "WIN";
                GameOverScreen.Setup(status);
                GameOverScreen.background.SetActive(true);
            }
        }
    }
}

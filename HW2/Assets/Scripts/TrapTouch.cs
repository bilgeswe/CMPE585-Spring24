using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTouch : MonoBehaviour
{
    public GameOverScreen gameOverScreen;
    public bool isAlive;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isAlive = false;
            string status = "LOSE";
            gameOverScreen.Setup(status);
            gameOverScreen.background.SetActive(true);
        }
    }
}


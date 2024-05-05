using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTouch : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    public bool isAlive;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isAlive = false;
            string status = "LOOSE";
            GameOverScreen.Setup(status);
            GameOverScreen.background.SetActive(true);
        }
    }
}


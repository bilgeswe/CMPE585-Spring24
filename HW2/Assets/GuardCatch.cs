using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardCatch : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    public bool isSeen= false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isSeen = true;
            string status = "LOSE";
            GameOverScreen.Setup(status);
            GameOverScreen.background.SetActive(true);
        }
    }
}


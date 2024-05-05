using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class GameOverScreen : MonoBehaviour
{
    OpenDoor openDoor;
    public GameObject background;
    public Text statusText;

    public void Setup(string status)
    {
        background.SetActive(true);
        statusText.text = "Status: " + status;
    }

    public void ReplayButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitButton()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    public Button myBtn;
    // Use this for initialization
    void Start()
    {
        if (myBtn.name == "StartButton")
        {
            myBtn.onClick.AddListener(StartGame);
        }
        else
        {
            myBtn.onClick.AddListener(QuitGame);
        }
    }
    void StartGame()
    {
        SceneManager.LoadScene("SampleScreen");
    }

    void QuitGame()
    {
        Application.Quit();
    }
}

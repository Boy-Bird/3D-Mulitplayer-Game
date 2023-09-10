using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public GameObject optionMenu;
    public bool isPaused;


    private void Start()
    {
        Debug.Log("Quit script running");
        optionMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    public void PauseGame()
    {
        optionMenu.SetActive(true);
        isPaused = true;
    }

    public void ResumeGame()
    {
        optionMenu.SetActive(false);
        isPaused = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

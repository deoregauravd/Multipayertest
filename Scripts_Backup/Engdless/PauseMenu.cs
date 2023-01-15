using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public Button pauseButton;

    private void Start()
    {
        pauseButton.onClick.AddListener(TogglePauseMenu);
    }

    private void TogglePauseMenu()
    {
        if (pauseMenu.activeInHierarchy)
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        }
        else
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
    }

     public void QuiteGame()
    {
        Application.Quit();
    }
}

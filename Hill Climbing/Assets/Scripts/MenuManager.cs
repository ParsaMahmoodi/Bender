using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject pauseUI;
    public void Start()
    {
        Time.timeScale = 1f;
    }
    public void ClickStart()
    {
        SceneManager.LoadScene("Level1");
    }
    public void ClickSetting()
    {
        SceneManager.LoadScene("Setting");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ClickAbout()
    {
        SceneManager.LoadScene("About");
    }
    public void BackToSetting()
    {
        SceneManager.LoadScene("Setting");
    }
    
    public void GamePause()
    {
        pauseUI.SetActive(!pauseUI.activeSelf); //Enable/disable the pause UI

        if (pauseUI.activeSelf) Time.timeScale = 0f;
        else Time.timeScale = 1f;
    }
    
}

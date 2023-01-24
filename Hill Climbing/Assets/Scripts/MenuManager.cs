using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
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
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float sceneLoadDelay = 1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "BikePlayer")
        {
            Invoke("ReloadSceneLevel1", sceneLoadDelay);
        }
        if (collision.tag == "CarPlayer")
        {
            Invoke("ReloadSceneLevel2", sceneLoadDelay);
        }

    }

    void ReloadSceneLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    void ReloadSceneLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

}

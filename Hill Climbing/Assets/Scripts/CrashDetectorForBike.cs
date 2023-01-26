using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetectorForBike : MonoBehaviour
{
    [SerializeField] float sceneLoadDelay = 0.5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground_Level_2")
        {
            Invoke("ReloadScene", sceneLoadDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene("Level2");
    }
}

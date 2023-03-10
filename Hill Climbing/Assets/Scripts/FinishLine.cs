using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float sceneLoadDelay = 1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Invoke("ReloadScene", sceneLoadDelay);
        }
        
    }

    void ReloadScene()
    {
        SceneManager.LoadScene("Level1");
    }

}

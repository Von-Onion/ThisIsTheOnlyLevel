using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    private Scene scene;
    private int sceneIndex;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        scene = SceneManager.GetActiveScene();
        sceneIndex = scene.buildIndex;

        SceneManager.LoadScene(sceneIndex + 1);
        Debug.Log("Exit Reached");
    }
}

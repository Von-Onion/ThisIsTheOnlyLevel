using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    [SerializeField] private string sceneName;
    private Scene scene;
    private int sceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        scene = SceneManager.GetActiveScene();
        sceneIndex = scene.buildIndex;

        SceneManager.LoadScene(sceneIndex + 1);
        Debug.Log("Exit Reached");
    }
}

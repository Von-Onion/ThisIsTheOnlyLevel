using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timeValue = 1;

    public Scene scene;
    public int sceneIndex;
    public Rigidbody2D rb2d;
    public float currentGravity;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        scene = SceneManager.GetActiveScene();

        sceneIndex = scene.buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        if(sceneIndex == 2){
            TimeScale(.5f);
        }
    }

    public void TimeScale(float scale){
        Time.timeScale = scale;
    }
}

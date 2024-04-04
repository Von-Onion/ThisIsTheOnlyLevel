using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private Scene scene;
    private int sceneIndex;
    public string sceneName;
  
    [SerializeField] private GameObject player;
    public Rigidbody2D rb2d;
    public bool isUpsideDown;

    [SerializeField] private int frameRate = 60;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        scene = SceneManager.GetActiveScene();

        sceneIndex = scene.buildIndex;

        sceneName = scene.name;

        isUpsideDown = false;

        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if(sceneName == "Leve2"){
            player.transform.localScale = player.transform.localScale * 2;
        }

        if(sceneName == "Level3")
        {
            TimeScale(2);
        }

        if(sceneName == "Level4"){
            isUpsideDown = true;
        }

        if(sceneName == "Level5"){
            isUpsideDown = true;
        }

        if (sceneName == "Level8")
        {
            Application.targetFrameRate = frameRate;
        }
    }

    public void TimeScale(float scale){
        Time.timeScale = scale;
    }

    public void Gravity(float scale)
    {
        rb2d.gravityScale = scale;
    }
}

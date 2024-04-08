using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public float remainingTime;
    public TextMeshProUGUI countDownText;

    public bool timerEnded;
    public GameObject endPlane;
    

    // Start is called before the first frame update
    void Start()
    {
        timerEnded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(remainingTime > 0){
            remainingTime -= Time.deltaTime;
            UpdateTimer(remainingTime);
        } else {
            remainingTime = 0;
            timerEnded = true;
            Debug.Log("Time's up");
        }

        if(timerEnded){
            Time.timeScale = 0;
            endPlane.SetActive(true);
            Cursor.visible = true;
        }

    }

    public void UpdateTimer(float currentTime){
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        countDownText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}

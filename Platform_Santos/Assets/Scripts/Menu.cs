using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private string sceneName;
    public GameObject selectPanel;
    public GameObject optionsPanel;
    public GameObject instructionsPanel;
    private bool isOptionsActive = false;
    private bool isSelectActive = false;
    private bool isInstructionsActive = false;


    public void LevelSelect()
    {
        selectPanel.SetActive(true);
        isSelectActive = true;
    }

    public void Play()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Minecart");
    }

    public void Instructions()
    {
        isInstructionsActive = true;
        instructionsPanel.SetActive(true);
    }

    public void Back()
    {



        if (isSelectActive)
        {
            selectPanel.SetActive(false);
            isSelectActive = false;
        }
        else if(isOptionsActive)
        {
            optionsPanel.SetActive(false);
            isOptionsActive = false;
        }
        else
        {
            isInstructionsActive = false;
            instructionsPanel.SetActive(false);
        }
    }

    public void Options()
    {
        optionsPanel.SetActive(true);
        isOptionsActive = true;
    }
}

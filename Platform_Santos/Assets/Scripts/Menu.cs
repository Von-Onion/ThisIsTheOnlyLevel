using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private string sceneName;
    public GameObject selectPanel;
    public GameObject optionsPanel;
    private bool isOptionsActive = false;
    private bool isSelectActive = false;

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

    public void Back()
    {
        if (isSelectActive)
        {
            selectPanel.SetActive(false);
            isSelectActive = false;
        }
        else
        {
            optionsPanel.SetActive(true);
            isOptionsActive = false;
        }
    }

    public void Options()
    {
        optionsPanel.SetActive(true);
        isOptionsActive = true;
    }
}

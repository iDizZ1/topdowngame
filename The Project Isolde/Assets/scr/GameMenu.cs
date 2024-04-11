using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{

    public GameObject MenuObject;

    bool isActive = false;

    private void Start()
    {
        MenuObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenCloseMenu();
        }
    }

    public void OpenCloseMenu()
    {
        if (!isActive)
        {
            MenuObject.SetActive(true);
            isActive = true;
        }      
        else
        {
            MenuObject.SetActive(false);
            isActive = false;
        }
                
    }

    public void MenuQuit()
    {
        Application.Quit();
    }

    public void toMainMenu ()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }


}

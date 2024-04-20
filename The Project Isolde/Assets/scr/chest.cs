using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class chest : MonoBehaviour
{

public GameObject ChestObject;

    bool isActive = false;

    private void Start()
    {
        ChestObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            OpenCloseChest();
        }

    }

    public void OpenCloseChest()
    {
        if (!isActive)
        {
            ChestObject.SetActive(true);
            isActive = true;
        }      
        else
        {
            ChestObject.SetActive(false);
            isActive = false;
        }
                
    }
}
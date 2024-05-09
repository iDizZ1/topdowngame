using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    public GameObject DialogObject;

        void Update()
        
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                DialogObject.SetActive(true);
            }

   

        }
}

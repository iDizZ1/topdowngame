using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    public GameObject DialogObject;
    public GameObject DialogObject1;

        void Update()
        
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                DialogObject.SetActive(true);
                DialogObject1.SetActive(false);
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                DialogObject.SetActive(false);
                DialogObject1.SetActive(true);
            }
   

        }
}

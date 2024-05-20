using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    public GameObject DialogObject1;
    public GameObject DialogObject2;

        void Update()
        
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                DialogObject1.SetActive(true);
                DialogObject2.SetActive(false);
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                DialogObject1.SetActive(false);
                DialogObject2.SetActive(true);
            }
   

        }
}

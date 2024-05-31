using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogCatScene : MonoBehaviour
{
    public GameObject DialogObject;

        void Update()       
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                DialogObject.SetActive(true);
            }
        }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : UsingObjects
{
    void Update()
    {
        if (Input.GetKeyUp("g"))
        {
            BoxCollider2D.enabled = false;
        }
        if (Input.GetKeyUp("h"))
        {
            BoxCollider2D.enabled = true;
        }


    }
}
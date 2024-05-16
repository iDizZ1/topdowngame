using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseAvatar : MonoBehaviour
{
    public GameObject boltat;
    void Update()
    {
        if(boltat.activeSelf){
            Debug.Log("The GameObject is ACTIVE");
            gameObject.SetActive(true);
        }
        else{
            Debug.Log("The GameObject is INACTIVE");
            gameObject.SetActive(false);
        }     
    }
}

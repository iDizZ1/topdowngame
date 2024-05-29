using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogloc2 : MonoBehaviour
{
    public GameObject DialogObject1;
    public GameObject DialogObject2;
    public GameObject DialogObject3;
    public GameObject Object1;
    public GameObject Object2;
    public GameObject Object3;
    float distance;
    float distance1;
    float distance2;

        void Update()
        
        {
            distance = Vector3.Distance(Object1.transform.position, gameObject.transform.position);
            distance1 = Vector3.Distance(Object2.transform.position, gameObject.transform.position);
            distance2 = Vector3.Distance(Object3.transform.position, gameObject.transform.position);
            if (Input.GetKeyDown(KeyCode.B) && distance < 2.2f)
            {
                DialogObject1.SetActive(true);
            }
            if (distance > 2.2f)
            {
                DialogObject1.SetActive(false);
            }
            

            if (Input.GetKeyDown(KeyCode.B) && distance1 < 2.2f)
            {
                DialogObject2.SetActive(true);
            }
            if (distance1 > 2.2f)
            {
                DialogObject2.SetActive(false);
            }

            if (Input.GetKeyDown(KeyCode.B) && distance2 < 2.2f)
            {
                DialogObject3.SetActive(true);
            }
            if (distance2 > 2.2f)
            {
                DialogObject3.SetActive(false);
            }
            
   

        }
}

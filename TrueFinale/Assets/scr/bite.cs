using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bite : MonoBehaviour
{
    public GameObject Human;
    void OnEnable(){
        StartCoroutine(SomeCoroutine());
    }
    void Update(){
        gameObject.transform.position = Human.transform.position;
    }
    private IEnumerator SomeCoroutine(){
        yield return new WaitForSeconds(0.6f); 
        gameObject.SetActive(false);
    }
}

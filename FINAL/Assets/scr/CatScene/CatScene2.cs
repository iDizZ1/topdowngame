using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatScene2 : MonoBehaviour
{
    public GameObject black;
    public int w;
    void Start()
    {
        w = 0;
    }

    void Update()
    {
        if (w == 0) {
            StartCoroutine(SomeCoroutine());
        }
    }

    private IEnumerator SomeCoroutine(){
        yield return new WaitForSeconds(4f);
        black.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Cat-Scene3"); 
    }
}

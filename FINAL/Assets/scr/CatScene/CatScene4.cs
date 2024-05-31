
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatScene4 : MonoBehaviour
{
    public GameObject boltat;
    public GameObject black;
    public int w;
    void Start()
    {
        w = 0;
    }

    void Update()
    {
        if (boltat.activeInHierarchy && w == 0) {
            w = 1;
        }
        if (boltat.activeInHierarchy){
        
        } else if(w == 1){
            w = 2;
            StartCoroutine(SomeCoroutine());
        }  
    }

    private IEnumerator SomeCoroutine(){
        yield return new WaitForSeconds(2f);
        black.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Loc7"); 
    }
 
}

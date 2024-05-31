using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatScene1 : MonoBehaviour
{
    public GameObject boltat;
    public int w;
    void Start()
    {
        w = 0;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.N)){
            SceneManager.LoadScene("Loc1"); 
        }
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
        w = 3;
        SceneManager.LoadScene("Loc1"); 
        w = 4;
    }
 
}

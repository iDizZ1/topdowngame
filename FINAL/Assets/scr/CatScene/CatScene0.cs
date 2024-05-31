using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatScene0 : MonoBehaviour
{
    public GameObject boltat;
    public GameObject back_0;
    public GameObject black;
    public GameObject back_1;
    public GameObject boltat_1B;
    public GameObject boltat_1a;
    public GameObject ppls;
    public GameObject zombie0;
    public GameObject zombie1;
    public GameObject zombie2;
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
        if (boltat_1a.activeInHierarchy){
        
        } else if(w == 4){
            w = 5;
            StartCoroutine(SomeCoroutine1());
        } 
        if (w == 7){
            w = 8;
            StartCoroutine(SomeCoroutine2());
        }
        if (w == 8){
            w = 9;
            StartCoroutine(SomeCoroutine3());
        }
    }

    private IEnumerator SomeCoroutine(){
        yield return new WaitForSeconds(2f);
        w = 3;
        back_0.SetActive(false);
        black.SetActive(true);
        yield return new WaitForSeconds(1f);
        boltat_1B.SetActive(true);
        w = 4;
    }
    private IEnumerator SomeCoroutine1(){
        yield return new WaitForSeconds(1f);
        w = 6;
        ppls.SetActive(false);
        zombie0.SetActive(true);
        zombie1.SetActive(true);
        zombie2.SetActive(true);
        black.SetActive(false);
        back_1.SetActive(true);
        w = 7;
    }
    private IEnumerator SomeCoroutine2(){
        yield return new WaitForSeconds(7f);
        w=8;
        black.SetActive(true);
        back_1.SetActive(false);
        zombie0.SetActive(false);
        zombie1.SetActive(false);
        zombie2.SetActive(false);     
        w=9;
    }
    private IEnumerator SomeCoroutine3(){
        yield return new WaitForSeconds(9f); 
        SceneManager.LoadScene("Cat-Scene1"); 
    }
}

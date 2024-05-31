using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GlobalW : MonoBehaviour
{
    public TMP_Text Textfield;
    public string name;
    public GameObject nameobj;
    void Start()
    {
        nameobj = GameObject.FindGameObjectWithTag("Name");
    }
    public void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        
    }
    void Update()
    {
        name = Textfield.text;
    }
    void OnLevelWasLoaded(){
        nameobj = GameObject.FindGameObjectWithTag("Name");
        HeroName namescr = nameobj.GetComponent<HeroName>();
        namescr.Hname = name;
    }
}

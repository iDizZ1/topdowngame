using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HeroName : MonoBehaviour
{
    public TMP_Text Textfield;
    public string Hname;
    
    void Update()
    {
       Textfield.text = Hname;
       if (Hname == ""){
            Hname = "Чара";
       }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace DialogueSystem
{
    public class DialogueLine : DialogueBaseClass
    {
        private TMP_Text textHolder;

        [Header ("Text Options")]
        [SerializeField] private string input;
        //[SerializeField] private Color textColor;
        [SerializeField] private TMP_FontAsset textFont;

        [Header ("Time Parametres")]
        [SerializeField] private float delay;
        [SerializeField] private float delayBetweenLines;

        [Header ("Sound")]
        [SerializeField] private AudioClip sound;

        [Header ("Character Image")]
        [SerializeField] private Sprite characterSprite;
        [SerializeField] private Image imageHolder;

        private void Awake()
        {
            textHolder = GetComponent<TMP_Text>();
            textHolder.text = "";
            
            imageHolder.sprite = characterSprite;
            imageHolder.preserveAspect = true;
        }

        private void Start()
        {
           StartCoroutine(WriteText(input, textHolder, textFont, delay, sound, delayBetweenLines));  
        }
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueBaseClass : MonoBehaviour
{
    public bool finished {get;private set;}

    protected IEnumerator WriteText(string input, TMP_Text textHolder, TMP_FontAsset textFont, float delay, AudioClip sound, float delayBetweenLines)
    {
        //textHolder.color = textColor;
        textHolder.font = textFont;

        for (int i = 0; i < input.Length; i++)
        {
            textHolder.text += input[i];

            //play letter sound
            //доделаю когда-то позже, LoL
            //SoundManager.instance.PlaySound(sound);
            
            yield return new WaitForSeconds(delay);
        }

        //yield return new WaitForSeconds(delayBetweenLines);
        //зачем я это писал хД
        //короче, теперь мы переключаем всё мышариком
        yield return new WaitUntil(() => Input.GetMouseButton(0));
        finished = true;
    }
}

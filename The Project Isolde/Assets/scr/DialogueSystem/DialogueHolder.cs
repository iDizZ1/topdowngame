using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DialogueSystem{
    public class DialogueHolder : MonoBehaviour
    {
<<<<<<< HEAD
        public Transform Player;

        void Update()
        {
=======
        public GameObject DialogObject;
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                DialogObject.SetActive(true);
            }
>>>>>>> ff0a5155902e0e6ca19998193a1ae34fd34c8283

        }

        private void Awake()
        {
<<<<<<< HEAD
            Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
=======
>>>>>>> ff0a5155902e0e6ca19998193a1ae34fd34c8283
            StartCoroutine(dialogueSequence());
        }
        private IEnumerator dialogueSequence()
        {
            for(int i = 0; i < transform.childCount; i++)
            {
                Deactivate();
                transform.GetChild(i).gameObject.SetActive(true);
                yield return new WaitUntil(() => transform.GetChild(i).GetComponent<DialogueLine>().finished);
            }
            gameObject.SetActive(false);
        }

        private void Deactivate()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
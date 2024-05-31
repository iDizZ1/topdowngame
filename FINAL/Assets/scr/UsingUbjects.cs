using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingObjects : MonoBehaviour
{
    protected Animator animationController;
    protected BoxCollider2D BoxCollider2D;
    protected float distance;
    protected bool isopend = false;

    //public Sprite usedSprite;
    //public Sprite defaultSprite;

    //protected SpriteRenderer SpriteRenderer;

    protected virtual void Start()
    {
        animationController = gameObject.GetComponent<Animator>();
        BoxCollider2D = gameObject.GetComponent<BoxCollider2D>();
        //SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        distance = Vector3.Distance(GameObject.Find("Hero").transform.position, gameObject.transform.position);
        if (Input.GetKeyUp("space") && distance < 2.2f)
        {
            if(isopend)
                close();
            else
                open();
        }
    }

    protected virtual void open()
    {
        isopend = true;
    }
    protected virtual void close()
    {
        isopend = false;
    }
}

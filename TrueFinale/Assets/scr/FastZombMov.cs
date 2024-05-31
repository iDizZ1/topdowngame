using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastZombMov : MonoBehaviour
{
    public GameObject FastZomb;

    private Rigidbody2D rb;
    public float moveSpeed = 5f;

    public Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        FastZomb = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if (FastZomb.transform.position.y <= gameObject.transform.position.y)
        {
            gameObject.transform.Translate(Vector3.up * -1f * moveSpeed * Time.deltaTime);
            if (FastZomb.transform.position.x >= gameObject.transform.position.x - 1f && FastZomb.transform.position.x <= gameObject.transform.position.x + 0.07f)
            {
                anim.SetBool("move_left", false);
                anim.SetBool("move_right", false);
                anim.SetBool("move_down", true);
                anim.SetBool("move_up", false);
            }
        }
        else
        {
            gameObject.transform.Translate(Vector3.up * 1f * moveSpeed * Time.deltaTime);
            if (FastZomb.transform.position.x >= gameObject.transform.position.x - 1f && FastZomb.transform.position.x <= gameObject.transform.position.x + 0.07f)
            {
                anim.SetBool("move_right", false);
                anim.SetBool("move_left", false);
                anim.SetBool("move_down", false);
                anim.SetBool("move_up", true);
            }
        }
        if (FastZomb.transform.position.x < gameObject.transform.position.x - 0.07f)
        {
            gameObject.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            anim.SetBool("move_left", true);
            anim.SetBool("move_right", false);
            anim.SetBool("move_down", false);
            anim.SetBool("move_up", false);
        }
        else if (FastZomb.transform.position.x > gameObject.transform.position.x + 0.07f)
        {
            gameObject.transform.Translate(Vector3.left * -1f * moveSpeed * Time.deltaTime);
            anim.SetBool("move_left", false);
            anim.SetBool("move_right", true);
            anim.SetBool("move_down", false);
            anim.SetBool("move_up", false);
        }
    }
}

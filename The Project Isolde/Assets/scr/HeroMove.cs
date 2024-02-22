using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 5f;
    private Vector2 moveVector;

    public Animator anim;
    
    void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D)){
            gameObject.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            anim.SetBool("move_right", true);
        } else {
            anim.SetBool("move_right", false);
        }
        if (Input.GetKey(KeyCode.A)){
            gameObject.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            anim.SetBool("move_left", true);
        } else {
            anim.SetBool("move_left", false);
        }
        if (Input.GetKey(KeyCode.S)){
            gameObject.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
            anim.SetBool("move_down", true);
        } else {
            anim.SetBool("move_down", false);
        }
        if (Input.GetKey(KeyCode.W)){
            gameObject.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            anim.SetBool("move_up", true);
        } else {
            anim.SetBool("move_up", false);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMove : MonoBehaviour
{
    public GameObject myaso;

    private Rigidbody2D rb;
    public float moveSpeed = 4.4f;

    public Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        myaso = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if (myaso.transform.position.y <= gameObject.transform.position.y) {
            gameObject.transform.Translate(Vector3.up * -1f * moveSpeed * Time.deltaTime);
            if (myaso.transform.position.x >= gameObject.transform.position.x - 1f && myaso.transform.position.x <= gameObject.transform.position.x + 0.07f){
                anim.SetBool("move_left", false);
                anim.SetBool("move_right", false);
                anim.SetBool("move_down", true);
                anim.SetBool("move_up", false);
            }
        }
        else{
            gameObject.transform.Translate(Vector3.up * 1f * moveSpeed * Time.deltaTime);
            if (myaso.transform.position.x >= gameObject.transform.position.x  - 1f && myaso.transform.position.x <= gameObject.transform.position.x + 0.07f){
                anim.SetBool("move_right", false);
                anim.SetBool("move_left", false);
                anim.SetBool("move_down", false);
                anim.SetBool("move_up", true);
            }
        }
        if (myaso.transform.position.x < gameObject.transform.position.x - 0.07f) {
            gameObject.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            anim.SetBool("move_left", true);
            anim.SetBool("move_right", false);
            anim.SetBool("move_down", false);
            anim.SetBool("move_up", false);
        } else if (myaso.transform.position.x > gameObject.transform.position.x + 0.07f){
            gameObject.transform.Translate(Vector3.left * -1f * moveSpeed * Time.deltaTime);
            anim.SetBool("move_left", false);
            anim.SetBool("move_right", true);
            anim.SetBool("move_down", false);
            anim.SetBool("move_up", false);
        }
    }
}

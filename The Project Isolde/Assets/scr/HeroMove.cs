using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 5f;
    public int byaka = 6;

    public Animator anim;

    public GameObject bul_sp;
    private Rigidbody2D rb_bullet;
    public GameObject bullet;
    public float bullet_speed = 20f;
    
    void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        bul_sp = GameObject.FindGameObjectWithTag("SpawnBullet");  
        rb_bullet = gameObject.AddComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D)){
            gameObject.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            anim.SetBool("move_right", true);
            byaka = 6;
        } else {
            anim.SetBool("move_right", false);
        }
        if (Input.GetKey(KeyCode.A)){
            gameObject.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            anim.SetBool("move_left", true);
            byaka = 4;
        } else {
            anim.SetBool("move_left", false);
        }
        if (Input.GetKey(KeyCode.S)){
            gameObject.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
            anim.SetBool("move_down", true);
            byaka = 2;
        } else {
            anim.SetBool("move_down", false);
        }
        if (Input.GetKey(KeyCode.W)){
            gameObject.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            anim.SetBool("move_up", true);
            byaka = 8;
        } else {
            anim.SetBool("move_up", false);
        }
        if (Input.GetKeyDown(KeyCode.Z)){
            StartCoroutine(Shoot());
        }
        if (Input.GetKeyDown(KeyCode.X)){
            anim.SetBool("shoot", true);
        }
    }

    IEnumerator Shoot()
    {
        anim.SetBool("shoot", true);
        yield return new WaitForSeconds(0.05f);
        Instantiate(bullet, bul_sp.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.20f);
        anim.SetBool("shoot", false);
    }
}

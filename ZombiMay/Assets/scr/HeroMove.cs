using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 5f;
    public int byaka = 6;
    private int a = 0;

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
        if (Input.GetKeyDown(KeyCode.Q) )
        {
            if (a == 0)
            {
                anim.SetBool("SwordSwing", true);
                a=1;
            }
            else
            {
                anim.SetBool("SwordSwing", false);
                a = 0;
            }
            
        }
        if ((Input.GetKey(KeyCode.D) || Input.GetKey("right")) & anim.GetBool("Attack") == false){
            gameObject.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            anim.SetBool("move_right", true);
            anim.SetBool("MoveWithoutWeap", true);
            byaka = 6;
        } else {
            anim.SetBool("move_right", false);
          
        }
        if ((Input.GetKey(KeyCode.A) || Input.GetKey("left")) & anim.GetBool("Attack") == false)
        {
            gameObject.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            anim.SetBool("move_left", true);
            anim.SetBool("MoveWithoutWeap", true);
            byaka = 4;
        } else {
            anim.SetBool("move_left", false);
            
        }
        if ((Input.GetKey(KeyCode.S) || Input.GetKey("down")) & anim.GetBool("Attack") == false){
            gameObject.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
            anim.SetBool("move_down", true);
            anim.SetBool("MoveWithoutWeap", true);
            byaka = 2;
        } else {
            anim.SetBool("move_down", false);
            
        }
        if ((Input.GetKey(KeyCode.W) || Input.GetKey("up")) & anim.GetBool("Attack") == false)
        {
            gameObject.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            anim.SetBool("move_up", true);
            anim.SetBool("MoveWithoutWeap", true);
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
        if (Input.GetKeyDown(KeyCode.C)) {
            anim.SetBool("Attack", true);
            StartCoroutine(ClWeapAttack());
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
    IEnumerator ClWeapAttack()
    {
        anim.SetBool("Attack", true);
        yield return new WaitForSeconds(0.6f);
        anim.SetBool("Attack", false);
    }
}

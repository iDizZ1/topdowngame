using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UIElements;

public class HeroMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed;
    public float sprint = 10f;
    public bool SprintBl = false;
    public float speed = 5f;

    public float maxvalue = 20f;
    public float value = 0f;
    public float seconds = 5f;


    public int byaka = 6;
    public bool move = false;
    private int a = 0;
    public int k = 0;

    public Animator anim;

    public GameObject bul_sp;
    public GameObject gren_sp;
    private Rigidbody2D rb_bullet;
    public GameObject bullet;
    public AudioClip reload;
    public AudioClip empty_ammo;
    public float bullets = 8f;
    public GameObject grenade;

    public bool gren_force = false;
    public float bullet_speed = 20f;

    public GameObject Sword;
    public GameObject bite;

    public GameObject SpawnSword;

    public bool PlayAudio = false;
    public AudioSource AudioSource;
    public AudioClip scream;
    public AudioClip sword_swing;

    public Vector3 vect = Vector3.right;

    public bool f = false;

    public float CoolDown = 0;

    void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        bul_sp = GameObject.FindGameObjectWithTag("SpawnBullet");
        rb_bullet = gameObject.AddComponent<Rigidbody2D>();
    }

    void Update()
    {
        move = false;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (a == 0)
            {
                anim.SetBool("SwordSwing", true);
                a = 1;
            }
            else
            {
                anim.SetBool("SwordSwing", false);
                a = 0;
            }

        }

        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))& anim.GetBool("Attack") == false)
        {
            move = true;
            gameObject.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            anim.SetBool("move_right", true);
            anim.SetBool("MoveWithoutWeap", true);
            byaka = 6;
        }
        else
        {
            anim.SetBool("move_right", false);


        }
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) & anim.GetBool("Attack") == false)
        {
            move = true;
            gameObject.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            anim.SetBool("move_left", true);
            anim.SetBool("MoveWithoutWeap", true);
            byaka = 4;
        }
        else
        {
            anim.SetBool("move_left", false);


        }
        if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) & anim.GetBool("Attack") == false)
        {
            move = true;
            gameObject.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
            anim.SetBool("move_down", true);
            anim.SetBool("MoveWithoutWeap", true);
            byaka = 2;
        }
        else
        {
            anim.SetBool("move_down", false);


        }
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) & anim.GetBool("Attack") == false)
        {
            move = true;
            gameObject.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            anim.SetBool("move_up", true);
            anim.SetBool("MoveWithoutWeap", true);
            byaka = 8;
        }
        else
        {
            anim.SetBool("move_up", false);


        }


        if (Input.GetKey(KeyCode.LeftShift) && move == true)
        {

            if (k <= 200)
            {
                moveSpeed = sprint;
                k += 1;
                value += 0.1f;
            }
            else
            {
                moveSpeed = speed;

            }

        }
        if (Input.GetKeyUp(KeyCode.LeftShift) && move == true)
        {
            SprintBl = true;
        }

        if (maxvalue == 20f)
        {
            f = true;
        }

        if (k > 200)
        {

            maxvalue -= Time.deltaTime * seconds;
            value -= (Time.deltaTime * seconds);

            if (f == true)
            {
                AudioSource.PlayOneShot(scream, 0.5f);
                f = false;
            }

            if (maxvalue < 0)
            {

                k = 0;
                maxvalue = 20f;
                value = 0;
            }
        }

        if ((k > 0 && k < 200) && SprintBl == true)
        {
            value -= (Time.deltaTime * seconds);
            moveSpeed = speed;
            if (value < 0)
            {
                k = 0;
                maxvalue = 20f;
                value = 0;
                SprintBl = false;
                moveSpeed = speed;
            }
        }





        if (Input.GetKeyDown(KeyCode.Z) && bullets>0 && anim.GetBool("SwordSwing") == false)
        {
            StartCoroutine(Shoot());
            bullets -= 1;
        }
        if (Input.GetKeyDown(KeyCode.Z) && bullets <= 0 && anim.GetBool("SwordSwing") == false)
        {
            AudioSource.PlayOneShot(empty_ammo,1);
        }
            if (Input.GetKeyDown(KeyCode.R) && bullets <= 7)
        {
            AudioSource.PlayOneShot(reload, 1);
            bullets = 8f;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            anim.SetBool("SwordSwing", false);
            //anim.SetBool("shoot", true);
        }
        if (Input.GetKeyDown(KeyCode.C) && anim.GetBool("SwordSwing") == true)
        {
            anim.SetBool("Attack", true);
            StartCoroutine(ClWeapAttack());
            AudioSource.PlayOneShot(sword_swing, 1);
        }
        if (Input.GetKeyDown (KeyCode.T) && CoolDown<=0) {

            StartCoroutine(ThrowGren());
            CoolDown = 100;
        }

        if (CoolDown >0)
        {
            CoolDown -= 0.1f;
        }



        IEnumerator Shoot()
        {
            anim.SetBool("shoot", true);
            yield return new WaitForSeconds(0.05f);
            Instantiate(bullet, bul_sp.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.20f);
            anim.SetBool("shoot", false);

        }


        IEnumerator ThrowGren()
        {
            var grend = Instantiate(grenade, bul_sp.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2f);
            Destroy(grend);
        }




        IEnumerator ClWeapAttack()
        {
            bite.SetActive(true);
            if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("sw_idle_right") == true || this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("sw_walk_right") == true)
            {
                var sword_copy = Instantiate(Sword, bul_sp.transform.position, Quaternion.identity);
                sword_copy.transform.position += new Vector3(1f, 0.1f, 0);
                sword_copy.transform.Rotate(0, 0, -90f);
                yield return new WaitForSeconds(0.1f);
                Destroy (sword_copy);
            }
            if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("sw_idle_left") == true || this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("sw_walk_left") == true)
            {
                var sword_copy = Instantiate(Sword, bul_sp.transform.position, Quaternion.identity);
                sword_copy.transform.position += new Vector3(-1f, 0.1f, 0);
                sword_copy.transform.Rotate(0, 0, -90f);
                yield return new WaitForSeconds(0.1f);
                Destroy(sword_copy);
            }
            if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("sw_idle_up") == true || this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("sw_walk_up") == true)
            {
                var sword_copy = Instantiate(Sword, bul_sp.transform.position, Quaternion.identity);
                sword_copy.transform.position += new Vector3(0, 0.7f, 0);
                yield return new WaitForSeconds(0.1f);
                Destroy(sword_copy);
            }
            if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("sw_idle_down") == true || this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("sw_walk_down") == true)
            {
                var sword_copy = Instantiate(Sword, bul_sp.transform.position, Quaternion.identity);
                sword_copy.transform.position += new Vector3(0, -1f, 0);
                yield return new WaitForSeconds(0.1f);
                Destroy(sword_copy);
            }

            yield return new WaitForSeconds(0.5f);
            anim.SetBool("Attack", false);
        }





    }
}

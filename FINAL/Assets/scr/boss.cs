using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class boss : MonoBehaviour
{
    public GameObject Boss_m;
    public GameObject shock_wave;
    public GameObject shock_wave_spawn;
    public int rnd;
    private Rigidbody2D rb;
    public float moveSpeed = 1f;
    public int a;
    public Animator anim;
    public bool f=false;

    private void Start()
    {
        InvokeRepeating("RandomNumber", 0, 5);


    }
    public void RandomNumber()
    {
        rnd = Random.Range(0, 2);
        print(rnd);
    }
    void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        Boss_m = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if (f == true)
        {
            var sh_wave_clone = Instantiate(shock_wave, shock_wave_spawn.transform.position, Quaternion.identity);
            Destroy(sh_wave_clone, 2);
        }
        if (rnd == 1) //1 = атака
        {
            StartCoroutine(attack_anim());
        }
        
        else
        {
            anim.SetBool("attack", false);
            if (Boss_m.transform.position.y <= gameObject.transform.position.y)
            {
                gameObject.transform.Translate(Vector3.up * -1f * moveSpeed * Time.deltaTime);
                if (Boss_m.transform.position.x >= gameObject.transform.position.x - 1f && Boss_m.transform.position.x <= gameObject.transform.position.x + 0.07f)
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
                if (Boss_m.transform.position.x >= gameObject.transform.position.x - 1f && Boss_m.transform.position.x <= gameObject.transform.position.x + 0.07f)
                {
                    anim.SetBool("move_right", false);
                    anim.SetBool("move_left", false);
                    anim.SetBool("move_down", false);
                    anim.SetBool("move_up", true);
                }
            }
            if (Boss_m.transform.position.x < gameObject.transform.position.x - 0.07f)
            {
                gameObject.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
                anim.SetBool("move_left", true);
                anim.SetBool("move_right", false);
                anim.SetBool("move_down", false);
                anim.SetBool("move_up", false);
            }
            else if (Boss_m.transform.position.x > gameObject.transform.position.x + 0.07f)
            {
                gameObject.transform.Translate(Vector3.left * -1f * moveSpeed * Time.deltaTime);
                anim.SetBool("move_left", false);
                anim.SetBool("move_right", true);
                anim.SetBool("move_down", false);
                anim.SetBool("move_up", false);
            }
        }
        
        




    }
    IEnumerator attack_anim()
    {
        anim.SetBool("attack", true);
        StartCoroutine(wave_anim());
        yield return new WaitForSeconds(1.2f);
        rnd = 0;
        
    }
    IEnumerator wave_anim()
    {
        f = true;
        yield return new WaitForSeconds(0.001f);
        f = false;
    }
}

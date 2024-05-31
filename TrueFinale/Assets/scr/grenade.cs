using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class grenade : MonoBehaviour
{
    public float force = 15f;
    public HeroMove grenade_dir;
    public Rigidbody2D rb;
    public int dir = 0;
    public GameObject Grenade;
    public Animator anim;
    public AudioSource gr;
    public AudioClip GrenExpl;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        grenade_dir = FindObjectOfType<HeroMove>();
        dir = grenade_dir.byaka;
        anim=GetComponent<Animator>();

    }
    void Update()
    {
        if (dir == 6)
        { 
            StartCoroutine(ThrowGrenRight());
        }
        else if (dir == 4)
        {
            StartCoroutine(ThrowGrenLeft());
        }
        else if (dir == 2)
        {
            StartCoroutine(ThrowGrenDown());
        }
        else if (dir == 8)
        {
            StartCoroutine(ThrowGrenUp());
        }
    }
    IEnumerator ThrowGrenRight()
    {
        rb.AddForce(transform.right * force);
        yield return new WaitForSeconds(0.1f);
        rb.AddForce(transform.right * -1f * force);
        yield return new WaitForSeconds(0.3f);
        rb.constraints = RigidbodyConstraints2D.FreezePosition;
        GetComponent<BoxCollider2D>().size = new Vector2(5,5);
        gr.PlayOneShot(GrenExpl, 1);
        anim.SetBool("Expl", true);
        yield return new WaitForSeconds(0.2f);
        GetComponent<BoxCollider2D>().size = new Vector2(0,0);
        yield return new WaitForSeconds(0.4f);
        DestroyPrefab();
    }
    IEnumerator ThrowGrenLeft()
    {
        rb.AddForce(transform.right * -1f * force);
        yield return new WaitForSeconds(0.1f);
        rb.AddForce(transform.right * force);
        yield return new WaitForSeconds(0.3f);
        rb.constraints = RigidbodyConstraints2D.FreezePosition;
        GetComponent<BoxCollider2D>().size = new Vector2(5, 5);
        anim.SetBool("Expl", true);
        yield return new WaitForSeconds(0.2f);
        GetComponent<BoxCollider2D>().size = new Vector2(0,0);
        yield return new WaitForSeconds(0.4f);
        DestroyPrefab();
    }
    IEnumerator ThrowGrenUp()
    {
        rb.AddForce(transform.up * force);
        yield return new WaitForSeconds(0.1f);
        rb.AddForce(transform.up * -1f * force);
        yield return new WaitForSeconds(0.3f);
        rb.constraints = RigidbodyConstraints2D.FreezePosition;
        GetComponent<BoxCollider2D>().size = new Vector2(5, 5);
        anim.SetBool("Expl", true);
        yield return new WaitForSeconds(0.2f);
        GetComponent<BoxCollider2D>().size = new Vector2(0,0);
        yield return new WaitForSeconds(0.4f);
        DestroyPrefab();
    }
    IEnumerator ThrowGrenDown()
    {
        rb.AddForce(transform.up *-1* force);
        yield return new WaitForSeconds(0.1f);
        rb.AddForce(transform.up * force);
        yield return new WaitForSeconds(0.3f);
        rb.constraints = RigidbodyConstraints2D.FreezePosition;
        GetComponent<BoxCollider2D>().size = new Vector2(5, 5);
        anim.SetBool("Expl", true);
        yield return new WaitForSeconds(0.2f);
        GetComponent<BoxCollider2D>().size = new Vector2(0,0);
        yield return new WaitForSeconds(0.4f);
        DestroyPrefab();
    }

    public void DestroyPrefab()
    {
        Destroy(Grenade);
        Destroy(gameObject);
    }
}


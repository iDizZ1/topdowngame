using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float force = 100f;
    public HeroMove bul_dir;
    public Rigidbody2D rb;
    public int dir = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bul_dir = FindObjectOfType<HeroMove>();   
        dir = bul_dir.byaka;
    }
    void Update(){
        if (dir == 6){
            rb.AddForce(transform.right * force);
        } else if (dir == 4){
            rb.AddForce(transform.right * -1 * force);
        } else if (dir == 2){
            rb.AddForce(transform.up * -1 * force);
        } else if (dir == 8){
            rb.AddForce(transform.up * force);
        } 
    }
}
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InfoPlayer: MonoBehaviour
{
    public float HP = 100f;
    public float maxHP = 100f;
    void Update()
    {
        if (HP > maxHP){
            HP = maxHP;
        }
        if (HP <= 0){
            SceneManager.LoadScene("Death");
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy") {
            HP = HP - 35;
             print("Objects are colliding");
        }
    }
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy") {
            HP = HP - 2;
             print("Objects ARE colliding");
        }
    }

}

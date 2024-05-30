using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InfoZombie: MonoBehaviour
{
    public float HP = 100f;
    public float maxHP = 100f;
    public AudioSource AudioSource;
    public AudioClip AudioClip;
    void Update()
    {
        if (HP > maxHP){
            HP = maxHP;
        }
        if (HP <= 0){
            
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Tichka") {
            HP = HP - 35;
            print("Objects are colliding");
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Sword")
        {
            print("Objects are colliding(sword)");
            HP = HP - 70;
        }
        if (other.gameObject.tag == "grenade")
        {
            HP = HP - 150;
        }

    }
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Tichka") {
            HP = HP - 2;
            print("Objects ARE colliding");
            Destroy(other.gameObject);
        }
    }

}

using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBar;
    public InfoPlayer player;

    void Start()
    {
        healthBar = GetComponent<Image>();
        player = FindObjectOfType<InfoPlayer>();
    }

    
    void Update()
    {
        healthBar.fillAmount = Mathf.Min(1,player.HP / player.maxHP);
    }
}
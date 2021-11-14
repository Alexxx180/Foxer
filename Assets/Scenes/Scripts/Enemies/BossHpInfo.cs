using UnityEngine;
using UnityEngine.UI;

public class BossHpInfo : MonoBehaviour
{
    public Slider bossHp;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bossHp.value--;
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class BossHpInfo : MonoBehaviour
{
    public byte bossNo;
    public Slider bossHp;
    public Achievements achievements;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bossHp.value--;
            if (bossHp.value <= 0)
                achievements.SetAchievement(0, bossNo);
        }
    }
}

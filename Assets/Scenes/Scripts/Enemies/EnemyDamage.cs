using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public HpControl player;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.Hurt();
        }
    }
}

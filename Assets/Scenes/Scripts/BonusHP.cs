using UnityEngine;

public class BonusHP : MonoBehaviour
{
    public HpControl hp;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            hp.Heal();
            Destroy(gameObject);
        }
    }
}

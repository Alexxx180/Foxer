using UnityEngine;

public class BonusLife : MonoBehaviour
{
    public HpControl hp;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            hp.LifeUp();
            Destroy(gameObject);
        }
    }
}

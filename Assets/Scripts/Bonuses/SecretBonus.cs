using UnityEngine;

public class SecretBonus : MonoBehaviour
{
    public HpControl hp;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            hp.Increase();
            Destroy(gameObject);
        }
    }
}

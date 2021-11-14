using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float bounce = 400f;
    public int hitPoints = 1;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Rigidbody2D rigidbody2D = collision.GetComponentInParent<Rigidbody2D>();
            rigidbody2D.AddForce(new Vector2(0f, bounce));
            hitPoints--;
            if (hitPoints <= 0)
                Destroy(gameObject.transform.parent.gameObject);
        }
    }
}

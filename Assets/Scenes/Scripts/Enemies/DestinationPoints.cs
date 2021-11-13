using UnityEngine;

public class DestinationPoints : MonoBehaviour
{
    public Transform nextDestination;
    public EnemyAI enemyAI;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            if (enemyAI.target != nextDestination)
                enemyAI.target = nextDestination;
        }
    }
}

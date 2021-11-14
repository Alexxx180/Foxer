using UnityEngine;

public class SecretRevealed : MonoBehaviour
{
    public byte secret;
    public Achievements achievements;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            achievements.SetAchievement(1, secret);
        }
    }
}

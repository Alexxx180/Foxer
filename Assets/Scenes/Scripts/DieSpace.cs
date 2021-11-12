using UnityEngine;
using UnityEngine.UI;

public class DieSpace : MonoBehaviour
{
    public GameObject respawn;
    public Slider hp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = respawn.transform.position;
            hp.value--;
        }
    }
}

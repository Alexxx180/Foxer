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
            collision.transform.position = PlayerRespawn();
        }
    }

    private Vector3 PlayerRespawn()
    {
        hp.value--;
        return respawn.transform.position;
    }

    public void Update()
    {
        if (Input.GetButtonDown("Forget"))
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.transform.position = PlayerRespawn();
        }
    }
}

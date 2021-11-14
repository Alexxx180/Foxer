using UnityEngine;

public class Activation : MonoBehaviour
{
    public GameObject targetObject;
    public bool state;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            targetObject.SetActive(state);
        }
    }
}

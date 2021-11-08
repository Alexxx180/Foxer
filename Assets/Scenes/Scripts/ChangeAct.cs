using UnityEngine;

public class ChangeAct : MonoBehaviour
{
    public GameObject previousAct;
    public GameObject nextAct;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            nextAct.SetActive(true);
            previousAct.SetActive(false);
        }
    }
}

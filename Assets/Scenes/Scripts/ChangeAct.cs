using UnityEngine;
using UnityEngine.UI;

public class ChangeAct : MonoBehaviour
{
    public GameObject previousAct;
    public GameObject nextAct;
    public Text actName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            nextAct.SetActive(true);
            previousAct.SetActive(false);
            actName.text = nextAct.name;
        }
    }
}

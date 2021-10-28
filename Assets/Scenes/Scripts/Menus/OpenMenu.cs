using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject settings;
    public GameObject exit;
    public GameObject hide;
    public AudioSource audio1;
    // Update is called once per frame
    void Update()
    {
        if (settings.activeSelf || exit.activeSelf)
            return;
        if (Input.GetButtonDown("Menu"))
            ActivateMenu(settings);
            
        if (Input.GetButtonDown("ExitMenu"))
            ActivateMenu(exit);
    }

    private void ActivateMenu(GameObject menu)
    {
        audio1.Play();
        menu.SetActive(true);
        hide.SetActive(false);
    }
}

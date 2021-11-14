using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
    public Slider hp;

    private void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CheckLives()
    {
        if (hp.value <= 0)
            ReloadLevel();
    }
}

using UnityEngine;
using UnityEngine.UI;

public class HpControl : MonoBehaviour
{
    public Slider lives;
    public Slider hp;

    public void CheckHP()
    {
        if (hp.value <= 0)
        {
            lives.value--;
            hp.value = hp.maxValue;
        }
    }

    public void LifeUp()
    {
        if (lives.value + 1 <= lives.maxValue)
            lives.value++;
    }

    public void Heal()
    {
        if (hp.value + 1 <= hp.maxValue)
            hp.value++;
    }

    public void Hurt()
    {
        hp.value--;
    }

    public void FullHeal()
    {
        hp.value = hp.maxValue;
    }

    public void Increase()
    {
        hp.maxValue++;
        hp.value++;
    }
}

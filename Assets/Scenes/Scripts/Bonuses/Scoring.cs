using System;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public Text score;
    public int bonus = 50;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            score.text = (Convert.ToInt32(score.text) + bonus).ToString();
        }
    }
}

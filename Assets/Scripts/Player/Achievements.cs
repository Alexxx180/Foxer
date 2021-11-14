using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Achievements : MonoBehaviour
{
    public Text secrets;
    public Text bosses;
    public Text score;

    public Text playerScore;

    private BitArray[] _achievements = new BitArray[] {
        new BitArray(new bool[] { false, false }),
        new BitArray(new bool[] { false, false, false,
            false, false, false, false, false, false })
    };

    public void SetAchievement(byte type, byte no)
    {
        _achievements[type][no] = true;
    }

    private int AchievementsCount(BitArray bitArray)
    {
        int[] ints = new int[(bitArray.Count >> 5) + 1];

        bitArray.CopyTo(ints, 0);

        int count = 0;

        // fix for not truncated bits in last integer that may have been set to true with SetAll()
        ints[ints.Length - 1] &= ~(-1 << (bitArray.Count % 32));

        for (int i = 0; i < ints.Length; i++)
        {

            int c = ints[i];

            unchecked
            {
                c = c - ((c >> 1) & 0x55555555);
                c = (c & 0x33333333) + ((c >> 2) & 0x33333333);
                c = ((c + (c >> 4) & 0xF0F0F0F) * 0x1010101) >> 24;
            }

            count += c;

        }

        return count;
    }

    private void SetOnTheEnd()
    {
        score.text = playerScore.text;
        bosses.text = AchievementsCount(_achievements[0]).ToString();
        secrets.text = AchievementsCount(_achievements[1]).ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BigGem"))
        {
            SetOnTheEnd();
        }
    }
}

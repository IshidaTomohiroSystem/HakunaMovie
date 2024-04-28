using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using TMPro;

public class LyricsManager : MonoBehaviour
{
    private LoadText loadText;

    [SerializeField]
    private TextAsset textAsset;
    [SerializeField]
    TextMeshProUGUI text1;
    [SerializeField]
    TextMeshProUGUI text2;

    int textNum;
    // Start is called before the first frame update
    void Awake()
    {
        loadText = new LoadText();
        loadText.LoadLyrics(textAsset);
        textNum = 0;
        text1.text = "";
        text2.text = "";
    }

    // Update is called once per frame
    public void UpdateLyrics(float songTime)
    {
        if(songTime > 10.0f && textNum == 0)
        {
            text1.text = loadText.GetLyrics(textNum);
            text2.text = loadText.GetLyrics(textNum + 1);
            textNum += 2;
        }

        if (songTime > 21.0f && textNum == 2)
        {
            text1.text = loadText.GetLyrics(textNum);
            text2.text = loadText.GetLyrics(textNum + 1);
            textNum += 2;
        }

        if (songTime > 33.0f && textNum == 4)
        {
            text1.text = loadText.GetLyrics(textNum);
            text2.text = loadText.GetLyrics(textNum + 1);
            textNum += 2;
        }

        if (songTime > 43.8f && textNum == 6)
        {
            text1.text = loadText.GetLyrics(textNum);
            text2.text = loadText.GetLyrics(textNum + 1);
            textNum += 2;
        }

        if (songTime > 57.0f && textNum == 8)
        {
            text1.text = loadText.GetLyrics(textNum);
            text2.text = loadText.GetLyrics(textNum + 1);
            textNum += 2;
        }

        if (songTime > 69.0f && textNum == 10)
        {
            text1.text = loadText.GetLyrics(textNum);
            text2.text = loadText.GetLyrics(textNum + 1);
            textNum += 2;
        }

        if (songTime > 80.0f && textNum == 12)
        {
            text1.text = loadText.GetLyrics(textNum);
            text2.text = loadText.GetLyrics(textNum + 1);
            textNum += 2;
        }

        if (songTime > 91.5f && textNum == 14)
        {
            text1.text = loadText.GetLyrics(textNum);
            text2.text = loadText.GetLyrics(textNum + 1);
            textNum += 2;
        }

        if (songTime > 107.0f && textNum == 16)
        {
            text1.text = "";
            text2.text = "";
        }

        if (songTime > 114.0f && textNum == 16)
        {
            text1.text = loadText.GetLyrics(textNum);
            text2.text = loadText.GetLyrics(textNum + 1);
            textNum += 2;
        }

        if (songTime > 125.5f && textNum == 18)
        {
            text1.text = loadText.GetLyrics(textNum);
            text2.text = loadText.GetLyrics(textNum + 1);
            textNum += 2;
        }

        if (songTime > 137.0f && textNum == 20)
        {
            text1.text = loadText.GetLyrics(textNum);
            text2.text = loadText.GetLyrics(textNum + 1);
            textNum += 2;
        }

        if (songTime > 148.0f && textNum == 22)
        {
            text1.text = loadText.GetLyrics(textNum);
            text2.text = loadText.GetLyrics(textNum + 1);
            textNum += 2;
        }

        if (songTime > 162.0f && textNum == 24)
        {
            text1.text = loadText.GetLyrics(textNum);
            text2.text = loadText.GetLyrics(textNum + 1);
            textNum += 2;
        }

        if (songTime > 173.0f && textNum == 26)
        {
            text1.text = loadText.GetLyrics(textNum);
            text2.text = loadText.GetLyrics(textNum + 1);
            textNum += 2;
        }

        if (songTime > 187.0f && textNum == 28)
        {
            text1.text = loadText.GetLyrics(textNum);
            text2.text = loadText.GetLyrics(textNum + 1);
            textNum += 2;
        }

        if (songTime > 198.0f && textNum == 30)
        {
            text1.text = loadText.GetLyrics(textNum);
            text2.text = loadText.GetLyrics(textNum + 1);
            textNum += 2;
        }

        if (songTime > 211.0f && textNum == 32)
        {
            text1.text = loadText.GetLyrics(textNum);
            text2.text = loadText.GetLyrics(textNum + 1);
            textNum += 2;
        }

        if (songTime > 233.0f && textNum == 34)
        {
            text1.text = loadText.GetLyrics(textNum);
            text2.text = loadText.GetLyrics(textNum + 1);
            textNum += 2;
        }

        if (songTime > 245.0f && textNum == 36)
        {
            text1.text = loadText.GetLyrics(textNum);
            text2.text = loadText.GetLyrics(textNum + 1);
            textNum += 2;
        }

        if (songTime > 261.0f && textNum == 38)
        {
            text1.text = "";
            text2.text = "";
            textNum += 2;
        }
    }
}

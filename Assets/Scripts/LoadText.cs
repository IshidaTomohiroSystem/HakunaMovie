using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class LoadText
{
    //　テキストファイルから読み込んだデータ
    private string loadText;

    //　改行で分割して配列に入れる
    private string[] splitText;

    public void LoadLyrics(TextAsset textAsset)
    {
        loadText = textAsset.text;
        splitText = loadText.Split(char.Parse("\n"));
    }

    public string GetLyrics(int line)
    {
        string lyrics = "";

        //　読み込んだテキストファイルの内容を表示
        if (splitText[line] != "")
        {
            lyrics = splitText[line];
        }
        return lyrics;
    }
}

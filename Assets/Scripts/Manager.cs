using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField]
    LightManager lightManager;
    [SerializeField]
    EffectManager effectManager;
    [SerializeField]
    LyricsManager lyricsManager;

    [SerializeField]
    private AudioSource source; //スピーカー・CDプレイヤー

    [SerializeField]

    private AudioClip clip1; //音源データ1
    float songTime;
    bool isStarted;
    // Start is called before the first frame update
    void Awake()
    {
        songTime = 0.0f;
        isStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (isStarted == false)
            {
                isStarted = true;
                source.clip = clip1; //再生したいclipを指定して
                source.Play(); //再生
            }
        }

        if (isStarted == true)
        {
            lightManager.UpdateLight(songTime);
            effectManager.UpdateEffect(songTime);
            lyricsManager.UpdateLyrics(songTime);
            float deltaTime = Time.deltaTime;
            songTime += deltaTime;
        }
    }
}

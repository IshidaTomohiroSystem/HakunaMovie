using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTest : MonoBehaviour
{
    [SerializeField]
    private AudioSource source; //スピーカー・CDプレイヤー
 
    [SerializeField]
    private AudioClip clip1; //音源データ1
 
    //[SerializeField]
    //private AudioClip clip2; //音源データ2
 
    void Awake()
    {
        source.clip = clip1; //再生したいclipを指定して
        source.Play(); //再生
    }
}

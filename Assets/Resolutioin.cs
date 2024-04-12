using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolutioin : MonoBehaviour
{
    [System.Obsolete]
    [RuntimeInitializeOnLoadMethod]
    static void Initialize()
    {
        Screen.SetResolution(1280, 720, FullScreenMode.Windowed, 60);
    }
}

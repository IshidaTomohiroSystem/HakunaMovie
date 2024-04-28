using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class EffectManager : MonoBehaviour
{
    [SerializeField]
    GameObject fireFlower;

    [SerializeField]
    GameObject plexus;

    [SerializeField]
    GameObject sakura;

    [SerializeField]
    GameObject butterfly;

    int effectNum;
    // Start is called before the first frame update
    void Awake()
    {
        effectNum = 0;
        fireFlower.gameObject.SetActive(false);
        plexus.gameObject.SetActive(false);
        sakura.gameObject.SetActive(false);
        butterfly.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void UpdateEffect(float songTime)
    {
        if (songTime < 9.0f && effectNum == 0)
        {
            plexus.gameObject.SetActive(true);
            effectNum++;
        }
        if (songTime > 9.0f && effectNum == 1)
        {
            plexus.gameObject.SetActive(false);
            butterfly.gameObject.SetActive(true);
            effectNum++;
        }

        if (songTime > 57.0f && effectNum == 2)
        {
            sakura.gameObject.SetActive(true);
            effectNum++;
        }

        if (songTime > 107.0f && effectNum == 3)
        {
            sakura.gameObject.SetActive(false);
            effectNum++;
        }

        if (songTime > 162.0f && effectNum == 4)
        {
            sakura.gameObject.SetActive(true);
            effectNum++;
        }

        if (songTime > 211.0f && effectNum == 5)
        {
            sakura.gameObject.SetActive(false);
            butterfly.gameObject.SetActive(false);
            effectNum++;
        }

        if (songTime > 233.0f && effectNum == 6)
        {
            fireFlower.gameObject.SetActive(true);
            plexus.gameObject.SetActive(true);
            effectNum++;
        }

        if (songTime > 261.0f && effectNum == 7)
        {
            fireFlower.gameObject.SetActive(false);
            plexus.gameObject.SetActive(false);
            butterfly.gameObject.SetActive(true);
            effectNum++;
        }
    }
}

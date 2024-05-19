using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class LightManager : MonoBehaviour
{
    [SerializeField]
    Light mainLight;

    [SerializeField]
    Light pointLight;

    [SerializeField]
    Light spotLight1;
    [SerializeField]
    Light spotLight2;
    [SerializeField]
    Light spotLight3;
    [SerializeField]
    Light spotLight4;


    readonly float mainLightIntensity = 745.0f;
    readonly float pointLightIntensity = 64.0f;

    readonly float spotRotateMax = 30.0f;
    readonly float spotSpeed = 0.2f;

    int LightTiming;

    int dir1;
    int dir2;
    int dir3;
    int dir4;

    void Awake()
    {
        mainLight.intensity = 0.0f;
        pointLight.intensity = 0.0f;
        LightTiming = 0;

        dir1 = 1;
        dir2 = -1;
        dir3 = 1;
        dir4 = -1;
    }

    // Update is called once per frame
    public void UpdateLight(float songTime)
    {
        float deltaTime = Time.deltaTime;

        if (songTime < 9.0f)
        {
            spotLight1.gameObject.transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f), spotSpeed * dir1);
            float spot1Y = spotLight1.gameObject.transform.rotation.eulerAngles.y;
            float spot1teY = spotLight1.gameObject.transform.rotation.y;
            spot1Y = spot1Y > 180 ? spot1Y - 360 : spot1Y;
            if (spot1Y  > spotRotateMax)
            {
                dir1 = -1;
            }
            else if(spot1Y <-spotRotateMax)
            {
                dir1 = 1;
            }

            spotLight2.gameObject.transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f), spotSpeed * dir2);
            float spot2Y = spotLight2.gameObject.transform.rotation.eulerAngles.y;
            spot2Y = spot2Y > 180 ? spot2Y - 360 : spot2Y;

            if (spot2Y > spotRotateMax)
            {
                dir2 = -1;
            }
            else if (spot2Y < -spotRotateMax)
            {
                dir2 = 1;
            }

            spotLight3.gameObject.transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f), spotSpeed * dir3);
            float spot3Y = spotLight3.gameObject.transform.rotation.eulerAngles.y;
            spot3Y = spot3Y > 180 ? spot3Y - 360 : spot3Y;

            if (spot3Y > spotRotateMax)
            {
                dir3 = -1;
            }
            else if (spot3Y < -spotRotateMax)
            {
                dir3 = 1;
            }
            spotLight4.gameObject.transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f), spotSpeed * dir4);
            float spot4Y = spotLight4.gameObject.transform.rotation.eulerAngles.y;
            spot4Y = spot4Y > 180 ? spot4Y - 360 : spot4Y;

            if (spot4Y > spotRotateMax)
            {
                dir4 = -1;
            }
            else if (spot4Y < -spotRotateMax)
            {
                dir4 = 1;
            }
        }

        if (songTime > 9.0f && songTime < 10.0f)
        {
            mainLight.intensity += mainLightIntensity / (1 / deltaTime);
            pointLight.intensity += pointLightIntensity / (1 / deltaTime);
            if (LightTiming == 0)
            {
                mainLight.gameObject.SetActive(true);
                pointLight.gameObject.SetActive(true);

                spotLight1.gameObject.SetActive(false);
                spotLight2.gameObject.SetActive(false);
                spotLight3.gameObject.SetActive(false);
                spotLight4.gameObject.SetActive(false);

                LightTiming++;
            }
        }

        if (songTime > 210.0f && songTime < 211.0f)
        {
            pointLight.intensity -= pointLightIntensity / (1 / deltaTime);
        }

        if (songTime > 232.0f && songTime < 233.0f)
        {
            pointLight.intensity += pointLightIntensity / (1 / deltaTime);
        }

        if (songTime > 261.0f && songTime < 262.0f)
        {
            mainLight.intensity -= mainLightIntensity / (1 / deltaTime);
            pointLight.intensity -= pointLightIntensity / (1 / deltaTime);
        }
    }
}

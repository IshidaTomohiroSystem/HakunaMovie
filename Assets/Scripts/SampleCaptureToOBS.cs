using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleCaptureToOBS : MonoBehaviour
{
    private UnityCapture.Interface m_captureInterface = null;
    //[SerializeField] private Camera m_panorama180Render = null;
    [SerializeField] private RenderTexture rt = null;
    void Start()
    {
        //// Get Panorama180Render component from MainCamera.
        //if (Camera.main != null)
        //{
        //    GameObject g = Camera.main.gameObject;
        //    if (g != null)
        //    {
        //        m_panorama180Render = g.GetComponent<"">();
        //    }
        //}
        //if (m_panorama180Render == null)
        //{
        //    Debug.Log("The Panorama180Render component is not assigned to MainCamera.");
        //    return;
        //}
        //
        ////------------------------------------------------.
        //// Set the parameters of Panorama180 Render.
        ////------------------------------------------------.
        //// Set GameViewMode (Default view).
        //m_panorama180Render.SetGameViewMode(Panorama180Render.GameViewMode.Default);
        //
        //// Set IPD(Interpupillary distance. unit m).
        //m_panorama180Render.SetIPD(0.064f);
        //
        //// Set texture size as Cubemap (512/1024/2048/4096/8192).
        //m_panorama180Render.SetRenderTextureSize(1024);
        //
        //// Post Processing On / Off.
        //m_panorama180Render.SetPostProcessing(true);
        //
        //// Set Panorama180.
        //m_panorama180Render.SetPanoramaMode(Panorama180Render.PanoramaMode.Panorama180);
        //
        //// Set Stereo.
        //m_panorama180Render.SetEyesType(Panorama180Render.EyesType.Stereo);
        //
        //// Output resolution at Panorama180.
        //m_panorama180Render.SetOutputTextureSizeType(Panorama180Render.OutputTextureSizeType._1024);
        //
        //// Begin capture.
        //m_panorama180Render.BeginCapture();

        //------------------------------------------------.
        // Create UnityCapture.
        //------------------------------------------------.
        m_captureInterface = new UnityCapture.Interface(UnityCapture.ECaptureDevice.CaptureDevice1);
    }

    void OnDestroy()
    {
        //if (m_captureInterface != null) m_captureInterface.Close();
        //if (m_panorama180Render != null) m_panorama180Render.EndCapture();
    }

    void Update()
    {
        if (m_captureInterface != null)
        {
            // Get RenderTexture.
            //RenderTexture rt = m_panorama180Render.GetRenderTexture();

            // Resize to fit OBS texture size.
            int rWidth = 1280;
            int rHeight = 720;
            RenderTexture tmpRT = RenderTexture.GetTemporary(rWidth, rHeight, 0, RenderTextureFormat.ARGB32);
            Graphics.Blit(rt, tmpRT);

            // Send RenderTexture to OBS.
            UnityCapture.ECaptureSendResult result = m_captureInterface.SendTexture(tmpRT);

            RenderTexture.ReleaseTemporary(tmpRT);
        }
    }
}

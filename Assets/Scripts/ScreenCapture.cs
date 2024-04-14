using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ScreenCapture : MonoBehaviour
{
    [SerializeField]
    private RenderTexture _targetRenderTexture;

    private Camera _targetCamera;

    private void Start()
    {
        CaptureStart(Camera.main);
    }

    /// <summary>
    /// 指定したカメラが移しているもののキャプチャの開始
    /// </summary>
    /// <param name="camera">キャプチャしたい描画対象を写しているカメラ</param>
    public void CaptureStart(Camera camera)
    {
        _targetCamera = camera;
        CameraCaptureBridge.AddCaptureAction(_targetCamera, Capture);
    }

    /// <summary>
    /// キャプチャ終了
    /// </summary>
    public void CaptureEnd()
    {
        CameraCaptureBridge.RemoveCaptureAction(_targetCamera, Capture);
    }

    /// <summary>
    /// キャプチャ処理
    /// </summary>
    private void Capture(RenderTargetIdentifier renderTargetIdentifier, CommandBuffer commandBuffer)
    {
        commandBuffer.Blit(renderTargetIdentifier, _targetRenderTexture);
    }
}

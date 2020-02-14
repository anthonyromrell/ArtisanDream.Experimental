using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

[ExecuteInEditMode]
public class CanvasScale : MonoBehaviour
{
    [FormerlySerializedAs("HighResolution")] public FloatData highResolution;
    [FormerlySerializedAs("HighFactor")] public FloatData highFactor;
    [FormerlySerializedAs("LowFactor")] public FloatData lowFactor;

    private void Awake()
    {
        var rt = GetComponent<RectTransform>();
        
        var scale = GetComponent<CanvasScaler>();
        
        scale.scaleFactor = rt.rect.width > highResolution.value ? highFactor.value : lowFactor.value;
    }
}
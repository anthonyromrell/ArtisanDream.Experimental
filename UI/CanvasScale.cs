using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class CanvasScale : MonoBehaviour
{
    public FloatData HighResolution, HighFactor, LowFactor;
    
    private void Awake()
    {
        var rt = GetComponent<RectTransform>();
        
        var scale = GetComponent<CanvasScaler>();
        
        scale.scaleFactor = rt.rect.width > HighResolution.Value ? HighFactor.Value : LowFactor.Value;
    }
}
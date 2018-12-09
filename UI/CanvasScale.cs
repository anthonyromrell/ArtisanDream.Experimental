using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScale : MonoBehaviour
{
    public float HighResolution = 2000, HighFactor = 4, LowFactor = 2;
    
    void Awake()
    {
        RectTransform rt = GetComponent<RectTransform>();
        var scaler = GetComponent<CanvasScaler>();
        if (rt.rect.width > HighResolution)
        {
            scaler.scaleFactor = HighFactor;
        }
        else
        {
            scaler.scaleFactor = LowFactor;
        }
    }
}
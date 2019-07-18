using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ItemPreview : MonoBehaviour
{
    [HideInInspector]
    public Image img;
    
    private void Awake()
    {
        img = GetComponent<Image>();
    }
}
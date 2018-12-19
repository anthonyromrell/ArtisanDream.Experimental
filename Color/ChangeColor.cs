using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public ColorData ColorSelection;
    
    public enum ComponentsToChange
    {
        SpriteRenderer,
        Material,
        Image,
        Text
    }

    public ComponentsToChange ComponentToChange;

    private void Awake()
    {
        switch (ComponentToChange)
        
        {
            case ComponentsToChange.SpriteRenderer:
                GetComponent<SpriteRenderer>().color = ColorSelection.Value;
                break;
            case ComponentsToChange.Material:
                GetComponent<Material>().color = ColorSelection.Value;
                break;
            case ComponentsToChange.Image:
                GetComponent<Image>().color = ColorSelection.Value;
                break;
            case ComponentsToChange.Text:
                GetComponent<Text>().color = ColorSelection.Value;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
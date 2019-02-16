using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public ColorData ColorSelection;
    public UnityEvent ChangeOnTrigger;
    
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

    private void OnTriggerEnter(Collider obj)
    {
        obj.GetComponent<SpriteRenderer>().color = ColorSelection.Value;
    }
}
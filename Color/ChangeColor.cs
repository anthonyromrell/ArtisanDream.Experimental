using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    [FormerlySerializedAs("ColorSelection")] public ColorData colorSelection;
    [FormerlySerializedAs("ChangeOnTrigger")] public UnityEvent changeOnTrigger;
    
    public enum ComponentsToChange
    {
        SpriteRenderer,
        Material,
        Image,
        Text
    }

    [FormerlySerializedAs("ComponentToChange")] public ComponentsToChange componentToChange;

    private void Awake()
    {
        switch (componentToChange)
        
        {
            case ComponentsToChange.SpriteRenderer:
                GetComponent<SpriteRenderer>().color = colorSelection.value;
                break;
            case ComponentsToChange.Material:
                GetComponent<Material>().color = colorSelection.value;
                break;
            case ComponentsToChange.Image:
                GetComponent<Image>().color = colorSelection.value;
                break;
            case ComponentsToChange.Text:
                GetComponent<Text>().color = colorSelection.value;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private void OnTriggerEnter(Collider obj)
    {
        obj.GetComponent<SpriteRenderer>().color = colorSelection.value;
    }
}
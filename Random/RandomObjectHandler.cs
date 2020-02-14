using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[CreateAssetMenu(menuName = "Random/Object Handler")]
public class RandomObjectHandler : ScriptableObject
{
    public UnityEvent Event;

    [FormerlySerializedAs("NewObject")] public Object newObject;
    [FormerlySerializedAs("TypeOf")] public Object typeOf;

    [FormerlySerializedAs("ObjectSelector")] public RandomObjectSelector objectSelector;

    private void OnEnable()
    {
        Debug.Log(typeOf.GetType());
        newObject = (GameObject) objectSelector.ReturnRandomObject();
    }
}
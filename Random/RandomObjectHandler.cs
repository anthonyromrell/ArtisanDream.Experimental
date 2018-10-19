using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Random/Object Handler")]
public class RandomObjectHandler : ScriptableObject
{
    public UnityEvent Event;

    public Object NewObject;
    public Object TypeOf;

    public RandomObjectSelector ObjectSelector;

    private void OnEnable()
    {
        Debug.Log(TypeOf.GetType());
        NewObject = (GameObject) ObjectSelector.ReturnRandomObject();
    }
}
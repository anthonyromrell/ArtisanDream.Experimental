using UnityEngine;
using UnityEngine.Serialization;


[CreateAssetMenu(menuName = "Random/Object Selector")]
public class RandomObjectSelector : ScriptableObject
{
    [FormerlySerializedAs("ObjectList")] public GenericObjects objectList;
    [FormerlySerializedAs("Value")] public Object value;

    private void OnEnable()
    {
        if (objectList != null)
        {
            ReturnRandomObject();
        }
    }

    public Object ReturnRandomObject()
    {
        var obj = Random.Range(0, objectList.items.Count - 1);
        value = objectList.items[obj];
        return value;
    }
}
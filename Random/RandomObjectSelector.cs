using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Random/Object Selector")]
public class RandomObjectSelector : ScriptableObject
{
    public List<Object> ObjectList;

    public Object ReturnRandomObject()
    {
        var value = UnityEngine.Random.Range(0, ObjectList.Count - 1);
        return ObjectList[value];
    }
}
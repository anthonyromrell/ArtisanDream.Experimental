using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Random/Object Selector")]
public class RandomObjectSelector : ScriptableObject
{
    public List<Object> objectList;

    private void OnEnable()
    {
        if (objectList != null)
        {
            ReturnRandomObject();
        }
    }

    public Object ReturnRandomObject()
    {
        var obj = Random.Range(0, objectList.Count - 1);
        return objectList[obj];;
    }
}
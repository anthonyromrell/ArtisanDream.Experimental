using UnityEngine;


[CreateAssetMenu(menuName = "Random/Object Selector")]
public class RandomObjectSelector : ScriptableObject
{
    public GenericObjects ObjectList;
    public Object Value;

    private void OnEnable()
    {
        if (ObjectList != null)
        {
            ReturnRandomObject();
        }
    }

    public Object ReturnRandomObject()
    {
        var obj = Random.Range(0, ObjectList.Items.Count - 1);
        Value = ObjectList.Items[obj];
        return Value;
    }
}
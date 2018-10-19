using UnityEngine;
using UnityEngine.Events;

public class MatchID : MonoBehaviour
{
    public NameID Id;
    public UnityEvent OnMatch;

    private void OnTriggerEnter(Collider other)
    {
        var id = other.GetComponent<ObjectId>().Id;
        Call(id);
    }

    public void Call(NameID id)
    {
        if (id == Id)
        {
            OnMatch.Invoke();
        }
    }
}
using UnityEngine;
using UnityEngine.Events;

public class MatchID : MonoBehaviour
{
    public NameID Id;
    private NameID id;
    public UnityEvent OnMatch;

    private void OnTriggerEnter(Collider other)
    {
        id = other.GetComponent<ObjectID>().ID;
        Call(id);
    }

    public void Call(NameID match)
    {
        if (match == Id)
        {
            OnMatch.Invoke();
        }
    }
}
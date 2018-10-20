using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchID : MonoBehaviour
{
    public NameID Id;
    private NameID id;
    public UnityEvent OnMatch;
    public UnityEvent OnRestart;
    public FloatData HoldTime;

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
            StartCoroutine(Restart());
        }
    }

    public IEnumerator Restart()
    {
        yield return new WaitForSeconds(HoldTime.Value);
        OnRestart.Invoke();
    }
}
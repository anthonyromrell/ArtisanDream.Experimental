using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchID : MonoBehaviour
{
    public NameID ID;
    public UnityEvent OnMatch;
    public UnityEvent NoMatch;
    public bool MatchMade { private get; set; }

    private void OnTriggerEnter(Collider other)
    {
        var otherID = other.GetComponent<MatchID>();
        
        if (otherID.ID == ID || otherID.MatchMade)
        {
            OnMatch.Invoke();
        }
        else
        {
            NoMatch.Invoke();
        }
    }
}
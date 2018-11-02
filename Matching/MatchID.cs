using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchID : MonoBehaviour
{
    public NameID ID;
    public NameID MatchMadeID;
    public bool UseChangeOnMatch;
    //private NameID id;
    public UnityEvent OnMatch;
    public UnityEvent NoMatch;
   // public UnityEvent OnRestart;
   // public FloatData HoldTime;
    //public BoolData Matched;
    private bool internalMatch;
    
    private void OnTriggerEnter(Collider other)
    {
        var oId = other.GetComponent<ObjectID>();
        CompareMatch(oId.ID);

        if (!UseChangeOnMatch) return;
        oId.ID = MatchMadeID;
        ID = MatchMadeID;
    }

    public void CompareMatch(NameID match)
    {
        if (match == ID)
        {
            //Matched.Value = true;
            OnMatch.Invoke();
          //  StartCoroutine(Restart());
        }
        else
        {
            NoMatch.Invoke();
        }
    }

//    public void CallRestart()
//    {
//        StartCoroutine(Restart());
//    }
//
//    public IEnumerator Restart()
//    {
//        if (Matched)
//        {
//            yield return new WaitForSeconds(HoldTime.Value);
//        }
//
//        Matched.Value = false;
//        OnRestart.Invoke();
//    }
}
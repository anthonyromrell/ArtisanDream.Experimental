using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class MatchByTag : MonoBehaviour
{
    [FormerlySerializedAs("TagWord")] public string tagWord;

    private void OnTriggerEnter(Collider other)
    {
        if ( other.CompareTag(tagWord) )
        {
            print("Event");
        }
    }
}
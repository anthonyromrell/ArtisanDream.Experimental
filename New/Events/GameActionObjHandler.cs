using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class GameActionObjHandler : MonoBehaviour
{
   [FormerlySerializedAs("ActionObj")] public GameActionObj actionObj;
   [FormerlySerializedAs("RaiseEvent")] public UnityEvent raiseEvent;

   private void Awake()
   {
      actionObj.action += OnRaise;
   }

   private void OnRaise()
   {
      raiseEvent.Invoke();
   }
}
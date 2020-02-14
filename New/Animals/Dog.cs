using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[CreateAssetMenu]
public class Dog : Mammal
{
   [FormerlySerializedAs("Collar")] public GameObject collar;
   
   public void Bark()
   {
      Debug.Log("Bark");
   }
}

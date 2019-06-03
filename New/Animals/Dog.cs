using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class Dog : Mammal
{
   public GameObject Collar;
   
   public void Bark()
   {
      Debug.Log("Bark");
   }
}

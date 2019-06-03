using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class Animal : ScriptableObject
{
   public GameObject Art;
   public GameObject Hat;
   public float Health = 1;
   public Color SkinColor = Color.red;
   public float Speed = 10;
   public int Size = 1;
   public UnityEvent RunEvent, EatEvent;
   public GameObject ActionObj;

   public void Eat()
   {
      EatEvent.Invoke();
   }
   
   public void Sleep()
   {
      Debug.Log("Sleeping");
   }
   
   public void Move()
   {
      Debug.Log("Moving");
   }
   
   public void Breed()
   {
      Debug.Log("Breeding");
   }

}

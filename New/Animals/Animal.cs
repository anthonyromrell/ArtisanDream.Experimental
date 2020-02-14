using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[CreateAssetMenu]
public class Animal : ScriptableObject
{
   [FormerlySerializedAs("Art")] public GameObject art;
   [FormerlySerializedAs("Hat")] public GameObject hat;
   [FormerlySerializedAs("Health")] public float health = 1;
   [FormerlySerializedAs("SkinColor")] public Color skinColor = Color.red;
   [FormerlySerializedAs("Speed")] public float speed = 10;
   [FormerlySerializedAs("Size")] public int size = 1;
   [FormerlySerializedAs("RunEvent")] public UnityEvent runEvent;
   [FormerlySerializedAs("EatEvent")] public UnityEvent eatEvent;
   [FormerlySerializedAs("ActionObj")] public GameObject actionObj;

   public void Eat()
   {
      eatEvent.Invoke();
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

using UnityEngine;

[CreateAssetMenu]
public class InstancerDestroyer : ScriptableObject
{
   public GameObject Prefab;
   
   public void InstanceObjAtLocation(Transform location)
   {
      Instantiate(Prefab, location.position, Quaternion.identity);
   }

   public void InstanceObj (GameObject gObj)
   {
      Instantiate(gObj);
   }

   public void DestroyObj(GameObject gObj)
   {
      Destroy(gObj);
   }
}
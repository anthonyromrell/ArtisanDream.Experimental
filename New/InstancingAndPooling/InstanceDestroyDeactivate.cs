using UnityEngine;

[CreateAssetMenu]
public class InstanceDestroyDeactivate : ScriptableObject
{
   public GameObject obj;

   public void ObjectToInstanceOrUse (GameObject gObj)
   {
      obj = gObj;
   }
   
   public void InstanceObjAtLocation(Transform location)
   {
      Instantiate(obj, location.position, Quaternion.identity);
   }
   
   public void InstanceAndParent(Transform parentObj)
   {
      Instantiate(obj, parentObj);
   }

   public void UseObjAtLocation(Vector3Data location)
   {
      obj.transform.localPosition = location.value;
   }

   public void InstanceObj (GameObject gObj)
   {
      Instantiate(gObj);
   }

   public void DestroyObj(GameObject gObj)
   {
      Destroy(gObj);
   }

   public void DeactivateObj(GameObject gObj)
   {
      gObj.SetActive(false);
   }   
}
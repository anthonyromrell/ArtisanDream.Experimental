using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu]
public class ConfigureColorInstance : ScriptableObject
{
	[FormerlySerializedAs("Prefab")] public GameObject prefab;
	[FormerlySerializedAs("ConfigObj")] public ColorObjConfig configObj;

	public void OnConfigure()
	{
		var newObj = Instantiate(prefab);
		newObj.GetComponentInChildren<SpriteRenderer>().color = configObj.color.value;
		newObj.GetComponent<ObjectId>().id = configObj.id;
	}
}
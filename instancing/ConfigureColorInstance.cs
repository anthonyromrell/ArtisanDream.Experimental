using UnityEngine;

[CreateAssetMenu]
public class ConfigureColorInstance : ScriptableObject
{
	public GameObject Prefab;
	public ColorObjConfig ConfigObj;

	public void OnConfigure()
	{
		var newObj = Instantiate(Prefab);
		newObj.GetComponentInChildren<SpriteRenderer>().color = ConfigObj.Color.Value;
		newObj.GetComponent<ObjectID>().ID = ConfigObj.Id;
	}
}
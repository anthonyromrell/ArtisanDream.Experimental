using System.Collections;
using System.Collections.Generic;
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
		//Debug.Log(newObj.GetComponent<ObjectId>());
		newObj.GetComponent<ObjectId>().Id = ConfigObj.Id;
	}
}
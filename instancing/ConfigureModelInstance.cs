using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(menuName = "Instancing/ModelConfig")]
public class ModelConfig: ScriptableObject
{
	[FormerlySerializedAs("Prefab")] public GameObject prefab;
	[FormerlySerializedAs("ObjColor")] public Color objColor;

	public void OnConfigure()
	{
		var newPrefab = Instantiate(prefab);
		newPrefab.name = this.name;
		
		var newSprite = newPrefab.GetComponent<SpriteRenderer>();
	}
}

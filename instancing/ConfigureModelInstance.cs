using UnityEngine;

[CreateAssetMenu(menuName = "Instancing/ModelConfig")]
public class ModelConfig: ScriptableObject
{
	public GameObject Prefab;
	public Color ObjColor;

	public void OnConfigure()
	{
		var newPrefab = Instantiate(Prefab);
		newPrefab.name = this.name;
		
		var newSprite = newPrefab.GetComponent<SpriteRenderer>();
	}
}

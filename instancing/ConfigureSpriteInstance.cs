using UnityEngine;
using UnityEngine.Serialization;

//Made By Anthony Romrell
[CreateAssetMenu(menuName = "Instancing/SpriteConfig")]
public class SpriteConfig : ScriptableObject
{
	[FormerlySerializedAs("Prefab")] public GameObject prefab;
	[FormerlySerializedAs("SpriteImage")] public Sprite spriteImage;
	[FormerlySerializedAs("SpriteColor")] public Color spriteColor;

	public void OnConfigure()
	{
		var newPrefab = Instantiate(prefab);
		var newSprite = newPrefab.GetComponent<SpriteRenderer>();
		newSprite.sprite = spriteImage;
		newSprite.color = spriteColor;
	}
}
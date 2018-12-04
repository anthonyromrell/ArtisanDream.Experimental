using UnityEngine;

//Made By Anthony Romrell
[CreateAssetMenu(menuName = "Instancing/SpriteConfig")]
public class SpriteConfig : ScriptableObject
{
	public GameObject Prefab;
	public Sprite SpriteImage;
	public Color SpriteColor;

	public void OnConfigure()
	{
		var newPrefab = Instantiate(Prefab);
		var newSprite = newPrefab.GetComponent<SpriteRenderer>();
		newSprite.sprite = SpriteImage;
		newSprite.color = SpriteColor;
	}
}
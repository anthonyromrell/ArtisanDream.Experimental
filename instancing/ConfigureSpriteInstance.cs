using UnityEngine;

//Made By Anthony Romrell
[CreateAssetMenu(menuName = "Instancing/Configure Sprite Instance")]
public class ConfigureSpriteInstance : ScriptableObject
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
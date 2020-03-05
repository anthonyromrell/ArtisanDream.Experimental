using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(menuName = "Change Object")]
public class ChangeObject : ScriptableObject
{
    public ColorData Color { private get;  set; }
    public NameId Id { private get; set; }
    public GameAction sendChange;

    public void Change(SpriteRenderer spriteRenderer)
    {
        spriteRenderer.color = Color.value;
    }

    public void Change(Material material)
    {
        material.color = Color.value;
    }
    
}
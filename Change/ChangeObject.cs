using UnityEngine;

[CreateAssetMenu(menuName = "Change Object")]
public class ChangeObject : ScriptableObject
{
    public ColorData Color { private get;  set; }
    public NameId Id { private get; set; }
    public GameAction SendChange;

    public void Change(SpriteRenderer spriteRenderer)
    {
        spriteRenderer.color = Color.value;
    }

    public void Change(Material material)
    {
        material.color = Color.value;
    }
    
    public void Change(MatchIdBehaviour matchId)
    {
        matchId.nameIdObj = Id;
    }
}
using UnityEngine;

[CreateAssetMenu(menuName = "Change Object")]
public class ChangeObject : ScriptableObject
{
    public ColorData Color { private get;  set; }
    public NameID Id { private get; set; }
    public GameAction SendChange;

    public void Change(SpriteRenderer spriteRenderer)
    {
        spriteRenderer.color = Color.Value;
    }

    public void Change(Material material)
    {
        material.color = Color.Value;
    }
    
    public void Change(MatchID matchId)
    {
        matchId.ID = Id;
    }

    public void OnSendChange(GamePiece obj)
    {
        SendChange.Raise(obj);
    }
}
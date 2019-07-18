using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class StoreItem : ScriptableObject
{
    public GameAction ItemAction;
    public Sprite StorePreview;
    public GameObject UsableItem;
    public UnityEvent OnPurchase, OnUse;
    public Color PreviewColor;

    public int price;
    public bool purchased;
    public bool InUse;

    public void OnEnable()
    {
        ItemAction = ScriptableObject.CreateInstance<GameAction>();
    }

    public void OnUpdate()
    {
        ////ItemAction.Raise(this);
    }
}
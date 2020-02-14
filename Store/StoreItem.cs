using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[CreateAssetMenu]
public class StoreItem : ScriptableObject
{
    [FormerlySerializedAs("ItemAction")] public GameAction itemAction;
    [FormerlySerializedAs("StorePreview")] public Sprite storePreview;
    [FormerlySerializedAs("UsableItem")] public GameObject usableItem;
    [FormerlySerializedAs("OnPurchase")] public UnityEvent onPurchase;
    [FormerlySerializedAs("OnUse")] public UnityEvent onUse;
    [FormerlySerializedAs("PreviewColor")] public Color previewColor;

    public int price;
    public bool purchased;
    [FormerlySerializedAs("InUse")] public bool inUse;

    public void OnEnable()
    {
        itemAction = ScriptableObject.CreateInstance<GameAction>();
    }

    public void OnUpdate()
    {
        ////ItemAction.Raise(this);
    }
}
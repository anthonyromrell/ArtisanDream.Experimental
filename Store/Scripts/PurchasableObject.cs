using UnityEngine;

[CreateAssetMenu(fileName = "Purchase", menuName = "Store/Purchasable")]
public class PurchasableObject : ScriptableObject
{
    public Object Item;
    public Sprite PreviewArt;
    public int UsageCount = 3;
    public int Value;
    public bool Upgrade;
    public PurchasableObject UpgradeFrom;

    public bool Perpetual;
    public bool Instanciatable;

    public void CreateItem()
    {
        for (int i = 0; i < UsageCount; i++)
        {
            if (Instanciatable && Item is GameObject)
            {
                Instantiate(Item);
            }
        }
    }

    public void Used()
    {
        UsageCount--;
    }
}
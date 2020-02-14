using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StoreFront : ScriptableObject
{
    public StoreButton storeButton;

    public List<StoreItem> itemList;

    public void GenerateStore(Transform storeTransform)
    {
        foreach (var item in itemList)
        {
            ProcessButton(storeTransform, item);
        }
    }

    public void ProcessButton(Transform storeTransform, StoreItem item
    )
    {
        var newBtn = Instantiate(storeButton, storeTransform, true);
        newBtn.UpdateButton(item);

        if (!item.purchased)
        {
            newBtn.btn.onClick.AddListener(delegate { AddPurchase(item); });
            newBtn.btn.onClick.AddListener(delegate { newBtn.UseAddAction(item); });
        }
        else
        {
            
        }
        
        if (item.inUse)
        {
            newBtn.DisableButton();
//            newBtn.btn.interactable = false;
//            newBtn.purchasedImg.gameObject.SetActive(false);
        }
        else
        {
            
        }
    }
    
    private void AddPurchase(StoreItem storeItem)
    {
        //storeItem.purchased = true;
    }
}
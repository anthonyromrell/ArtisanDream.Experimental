using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(StoreButton))]
public class ItemsFromStore : MonoBehaviour
{
    public GameAction addToThisAction;
    private StoreButton storeButton;
    public InUseItems inUseItems;
    private StoreItem previousItem;

    public InUseItems.Items thisItem;
    private void Start()
    {
        storeButton = GetComponent<StoreButton>();
        storeButton.UpdateButton(inUseItems.ReturnItem(thisItem));
    }

    public void StartAddToThisAction()
    {
        addToThisAction.raise = AddToHandler;
    }

    private void AddToHandler(object item)
    {
        previousItem = storeButton.currentItem;
        var newItem = item as StoreItem;
        inUseItems.ChangeItem(thisItem, newItem);
        storeButton.UpdateButton(newItem);
        previousItem.inUse = false;
        previousItem.OnUpdate();
    }
}
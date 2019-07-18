using System;
using UnityEngine;

[CreateAssetMenu]
public class InUseItems : ScriptableObject
{
    public StoreItem itemOne, itemTwo, itemThree;
    public enum Items 
    {
        ItemOne,
        ItemTwo,
        ItemThree
    }
    
    public void ChangeItem(Items itemToChange, StoreItem item)
    {
        switch (itemToChange)
        {
            case Items.ItemOne:
                itemOne = item;
                break;
            case Items.ItemTwo:
                itemTwo = item;
                break;                                
            case Items.ItemThree:
                itemThree = item;
                break;
        }
    }

    public StoreItem ReturnItem(Items itemToChange)
    {
        StoreItem newItem = null;
        switch (itemToChange)
        {
            case Items.ItemOne:
                newItem = itemOne;
                break;
            case Items.ItemTwo:
                newItem = itemTwo;
                break;                                
            case Items.ItemThree:
                newItem = itemThree;
                break;
        }

        return newItem;
    }
}
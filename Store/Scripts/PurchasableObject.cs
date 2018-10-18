using UnityEngine;

[CreateAssetMenu(fileName = "Purchase", menuName = "Store/Purchasable")]
public class PurchasableObject : ScriptableObject
{
	public Object Item;
	public int Value;
}
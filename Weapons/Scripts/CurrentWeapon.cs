using UnityEngine;
using Weapons;

[CreateAssetMenu(fileName = "CurrentWeapon")]
public class CurrentWeapon : ScriptableObject
{
	public WeaponData currentWeaponData;
}
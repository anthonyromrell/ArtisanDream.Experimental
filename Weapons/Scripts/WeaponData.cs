using System;
using UnityEngine;

namespace Weapons
{
    [CreateAssetMenu(fileName = "WeaponData")]
    public class WeaponData: ScriptableObject
    {
        public Color activeColor = Color.yellow;
        public float firePower = 0.1f;
        public float fireRate = 0.25f;
        public float totalAmmo = 1f;
        
        [HideInInspector]
        public WeaponObjectBehaviour WeaponObject;

        private void OnEnable()
        {
            totalAmmo = 1f;
        }

        private void OnDisable()
        {
            WeaponObject = null;
        }
    }
}
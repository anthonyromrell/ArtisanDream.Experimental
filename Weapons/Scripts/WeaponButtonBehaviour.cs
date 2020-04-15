using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Weapons
{
    public class WeaponButtonBehaviour : MonoBehaviour
    {
        private const float V = 0.01f;
        public GameAction FireWeapon;
        private Image button;
        public GameAction EndGame;
        private Coroutine WaitToFire;
        public Image weaponBar;
        public int WeaponNum;
        public IntData WeaponNumData;
        public GameAction SendWeapon;
        [HideInInspector]
        public WeaponData WeaponDataObject;

        private WaitForFixedUpdateObj wffObj;
        private WaitForSecondsObj wfsObj;

        private void Start()
        {
            SendWeapon.Raise += GetWeaponHandler;
            button = GetComponent<Image>();
            EndGame.RaiseNoArgs += EndGameHandler;
            wffObj = ScriptableObject.CreateInstance<WaitForFixedUpdateObj>();
            wfsObj = ScriptableObject.CreateInstance<WaitForSecondsObj>();
            
        }

        private void EndGameHandler()
        {
            GetComponent<Button>().interactable = false;
        }

        private void GetWeaponHandler(object obj)
        {
            var data = obj as WeaponData;
            if (WeaponNumData.Value != WeaponNum) return;
            WeaponDataObject = data;
            button.color = WeaponDataObject.activeColor;
            weaponBar.color = WeaponDataObject.activeColor;
            weaponBar.fillAmount = WeaponDataObject.totalAmmo;
        }

        public void Click()
        {
            
            if (WaitToFire == null) WaitToFire = StartCoroutine(Fire());
        }

        private IEnumerator Fire()
        {
            if (weaponBar.fillAmount == 0) yield break;
            
            var tempAmount = weaponBar.fillAmount - WeaponDataObject.firePower;
            if (tempAmount < 0) tempAmount = 0;
            
            WeaponDataObject.WeaponObject.Fire(true);
            FireWeapon.RaiseNoArgs();
            
            while (weaponBar.fillAmount > tempAmount)
            {
                weaponBar.fillAmount -= V;
                yield return wffObj;
            }
            wfsObj.Seconds = WeaponDataObject.fireRate;
            yield return wfsObj;
            WeaponDataObject.totalAmmo = weaponBar.fillAmount;
            WaitToFire = null;
        }
    }
}
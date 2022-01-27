using UnityEngine;
using UnityEngine.Events;

namespace Weapons
{
    public class WeaponObjectBehaviour : MonoBehaviour
    {
        public WeaponData Data;
        public GameAction SendWeapon;
        private Transform attachPoint;
        public IntData WeaponNum;
        public UnityEvent FireEvent;
       

        private void Awake()
        {
            WeaponAttachPoint.AttachAction += AttachHandler;
            Data.WeaponObject = this;
        }

        private void OnTriggerEnter(Collider obj)
        {
            
            GetComponent<BoxCollider>().enabled = false;
            transform.parent = attachPoint.transform;
            Invoke(nameof(Attach), 0.25f);
        }

        private void AttachHandler(Transform _attachPoint)
        {
            attachPoint = _attachPoint;
        }

        private void Attach()
        {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
        }

        private void OnApplicationQuit()
        {
            WeaponNum.value = 0;
        }
        
        public void Fire(bool canFire)
        {
            FireEvent.Invoke();
        }
    }
}
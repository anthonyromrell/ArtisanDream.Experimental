using UnityEngine;
using UnityEngine.Events;
using Weapons;

public class WeaponAttachPoint : MonoBehaviour
{
    public static UnityAction<Transform> AttachAction;

    private void Start()
    {
        if (AttachAction != null)
            AttachAction(transform);
    }
}
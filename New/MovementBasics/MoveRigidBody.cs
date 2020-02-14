using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[RequireComponent(typeof(Rigidbody))]
public class MoveRigidBody : MonoBehaviour
{
    private Rigidbody rigid;
    [FormerlySerializedAs("Force")] public float force = 10;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rigid.AddForce(Input.GetAxis("Horizontal")*force,0,0);
    }
}

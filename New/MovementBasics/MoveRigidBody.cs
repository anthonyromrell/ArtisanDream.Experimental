using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class MoveRigidBody : MonoBehaviour
{
    private Rigidbody rigid;
    public float Force = 10;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rigid.AddForce(Input.GetAxis("Horizontal")*Force,0,0);
    }
}

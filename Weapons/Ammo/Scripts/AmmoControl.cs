using UnityEngine;

public class AmmoControl : MonoBehaviour
{
    
    
    public Animator ammoAnim; //Component Type
    public GameObject AmmoArt;
    public GameObject ammoGO; //Component Type

    public Rigidbody ammoRigid; //Component Type

    private void OnCollisionEnter()
    {
        //When contacts with another object with a collider component
        ammoAnim.SetBool("Impact", true); //Sets a boolean parameter in the Animator component
        ammoRigid.velocity = Vector3.zero; //stops the rigidbody component from moving
    }
}
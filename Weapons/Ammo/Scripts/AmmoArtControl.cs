using System.Collections;
using UnityEngine;

public class AmmoArtControl : MonoBehaviour
{
    public Animator ammoAnim;

    public GameObject ammoControl;
    public Rigidbody ammoRigid; //Component Type
    public SpriteRenderer ammoSprite;

    private void OnCollisionEnter()
    {
        //When contacts with another object with a collider component
        ammoAnim.SetBool("Impact", true); //Sets a boolean parameter in the Animator component
        ammoRigid.velocity = Vector3.zero; //stops the rigidbody component from moving
    }

//	public void StopImpact() {//Called from an animation event
//		ammoAnim.SetBool("Impact", false);//stops the explosion animation from playing
//	}

    private void DisableSprite()
    {
        //runs at the beginning of the first frame
        StartCoroutine(WaitDisable()); //runs a function that will hold until the end of the first frame
    }

    private IEnumerator WaitDisable()
    {
        //allows holds
        yield return new WaitForEndOfFrame(); //holds this function until the last of the frame called
        ammoControl.SetActive(false);
    }

    public void Restart()
    {
        //Called from and animation event
        ammoAnim.SetBool("Restart", false); //allows the start animation to play
    }
}
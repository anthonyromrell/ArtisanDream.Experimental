using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ApplyForces))]
public class AmmoProjectileBehaviour : MonoBehaviour
{

    private ApplyForces forces;
    private GameObject projectile, impact, flash;

    public AmmoProjectileConfig ammoConfig;
    // Start is called before the first frame update
    void Awake()
    {
        forces = GetComponent<ApplyForces>();

        projectile = Instantiate(ammoConfig.projectile, transform); 
        impact = Instantiate(ammoConfig.impact, transform); 
        //flash = Instantiate(ammoConfig.flash, transform);

        projectile.layer = 14;
        projectile.transform.Rotate(0,90,0);
       // projectile.transform.position= Vector3.zero;
       impact.transform.localScale = Vector3.one * 0.5f; 
       
        var rigid = GetComponent<Rigidbody>();
        var particles = projectile.GetComponent<ParticleSystem>();
        var impactParticles = impact.GetComponent<ParticleSystem>();
        
       
        rigid.Sleep();
    }
}
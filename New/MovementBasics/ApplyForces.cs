using UnityEngine;
using UnityEngine.Events;

public class ApplyForces : MonoBehaviour
{
    public float holdTime = 1.0f;
    public float PowerLevel = 10f;
    public Vector3 forcesDirA, forcesDirB;
    public UnityEvent EnableEvent, DisableEvent, TriggerEnterEvent;
    private Rigidbody rBody;
    public BoolData DirectionBool;
    
   
    private void Awake()
    {
        rBody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        Invoke(nameof(Disable), holdTime);
       
        rBody.WakeUp();
        if (DirectionBool.Value)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
            rBody.AddForce(forcesDirA*PowerLevel);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0,0,180);
            rBody.AddForce(forcesDirB*PowerLevel);
        }
        EnableEvent.Invoke();
    }

    private void Disable()
    {
        DisableEvent.Invoke();
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        rBody.Sleep();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        print(other);
        TriggerEnterEvent.Invoke();
    }
}
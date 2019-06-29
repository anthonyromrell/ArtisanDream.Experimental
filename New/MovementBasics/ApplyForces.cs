using UnityEngine;
using UnityEngine.Events;

public class ApplyForces : MonoBehaviour
{
    public float holdTime = 1.0f;
    public Vector3 forces;
    public UnityEvent EnableEvent, DisableEvent, TriggerEnterEvent;
    private Rigidbody rBody;
   
    private void Awake()
    {
        rBody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        Invoke(nameof(Disable), holdTime);
        rBody.WakeUp();
        rBody.AddForce(forces);
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
        TriggerEnterEvent.Invoke();
    }
}
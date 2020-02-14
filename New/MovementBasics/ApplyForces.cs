using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class ApplyForces : MonoBehaviour
{
    public float holdTime = 1.0f;
    [FormerlySerializedAs("PowerLevel")] public float powerLevel = 10f;
    public Vector3 forcesDirA, forcesDirB;
    [FormerlySerializedAs("EnableEvent")] public UnityEvent enableEvent;
    [FormerlySerializedAs("DisableEvent")] public UnityEvent disableEvent;
    [FormerlySerializedAs("TriggerEnterEvent")] public UnityEvent triggerEnterEvent;
    private Rigidbody rBody;
    [FormerlySerializedAs("DirectionBool")] public BoolData directionBool;
    
   
    private void Awake()
    {
        rBody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        Invoke(nameof(Disable), holdTime);
       
        rBody.WakeUp();
        if (directionBool.value)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
            rBody.AddForce(forcesDirA*powerLevel);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0,0,180);
            rBody.AddForce(forcesDirB*powerLevel);
        }
        enableEvent.Invoke();
    }

    private void Disable()
    {
        disableEvent.Invoke();
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        rBody.Sleep();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        print(other);
        triggerEnterEvent.Invoke();
    }
}
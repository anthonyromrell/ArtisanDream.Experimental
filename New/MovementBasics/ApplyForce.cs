using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[RequireComponent(typeof(Rigidbody))]
public class ApplyForce : MonoBehaviour
{

    [FormerlySerializedAs("StartPoint")] public Transform startPoint;
    private Rigidbody rigid;
    [FormerlySerializedAs("Forces")] public Vector3 forces;
    [FormerlySerializedAs("HoldTime")] public float holdTime = 3;
    private Coroutine cr;
    [FormerlySerializedAs("UseGravity")] public bool useGravity = false;
    [FormerlySerializedAs("CanRunEvent")] public UnityEvent canRunEvent;
    [FormerlySerializedAs("StartEvent")] public UnityEvent startEvent;
    [FormerlySerializedAs("ResetEvent")] public UnityEvent resetEvent;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.Sleep();
        canRunEvent.AddListener(UseApplyForce);
    }

    public void RunApplyForce()
    {
        canRunEvent.Invoke();
    }

    private void UseApplyForce()
    {
        startEvent.Invoke();
        
        rigid.WakeUp();
        rigid.useGravity = useGravity;
        rigid.AddForce(forces);
        
        if (cr == null)
        {
            cr = StartCoroutine(Hold());
        }
        canRunEvent.RemoveListener(UseApplyForce);
    }

    private IEnumerator Hold()    
    {
        yield return new WaitForSeconds(holdTime);
        resetEvent.Invoke();
    }

    public void Reset()
    {
        rigid.useGravity = false;
        var transformObj = transform;
        transformObj.rotation = Quaternion.identity;
        transformObj.position = startPoint.position;
        rigid.Sleep();
        cr = null;
        canRunEvent.AddListener(UseApplyForce);
    }
}
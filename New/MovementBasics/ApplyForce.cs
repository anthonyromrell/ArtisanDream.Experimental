using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class ApplyForce : MonoBehaviour
{

    public Transform StartPoint;
    private Rigidbody rigid;
    public Vector3 Forces;
    public float HoldTime = 3;
    private Coroutine cr;
    public bool UseGravity = false;
    public UnityEvent CanRunEvent, StartEvent, ResetEvent;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.Sleep();
        CanRunEvent.AddListener(UseApplyForce);
    }

    public void RunApplyForce()
    {
        CanRunEvent.Invoke();
    }

    private void UseApplyForce()
    {
        StartEvent.Invoke();
        
        rigid.WakeUp();
        rigid.useGravity = UseGravity;
        rigid.AddForce(Forces);
        
        if (cr == null)
        {
            cr = StartCoroutine(Hold());
        }
        CanRunEvent.RemoveListener(UseApplyForce);
    }

    private IEnumerator Hold()    
    {
        yield return new WaitForSeconds(HoldTime);
        ResetEvent.Invoke();
    }

    public void Reset()
    {
        rigid.useGravity = false;
        var transformObj = transform;
        transformObj.rotation = Quaternion.identity;
        transformObj.position = StartPoint.position;
        rigid.Sleep();
        cr = null;
        CanRunEvent.AddListener(UseApplyForce);
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Pooling), typeof(GameActionHandler))]
public class InstanceFromConfig : MonoBehaviour
{
    //Redo this!!!
    private Pooling pool;
    public GameAction OutsideAction;
    public UnityEvent activateEvent;
    
    private void Start()
    {
        
        pool = GetComponent<Pooling>();
        var item = pool.ItemToPool.GetComponent<AmmoProjectileBehaviour>().ammoConfig;
        var newItem = Instantiate(item.flash, transform);
        newItem.transform.Rotate(0,90,0);
        newItem.transform.localScale = Vector3.one*10;
        newItem.SetActive(false);
        OutsideAction.RaiseNoArgs = RaiseNoArgs;
        activateEvent.AddListener(delegate { newItem.SetActive(true); });;
    }

    private void RaiseNoArgs()
    {
        activateEvent.Invoke();
    }
}

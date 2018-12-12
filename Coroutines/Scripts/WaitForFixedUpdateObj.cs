using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Coroutines/Wait For Fixed Update Object")]
public class WaitForFixedUpdateObj : ScriptableObject, IWait
{
    public object Obj { get; set; }
    public void Create()
    {
        Obj = new WaitForFixedUpdate();
    }
}
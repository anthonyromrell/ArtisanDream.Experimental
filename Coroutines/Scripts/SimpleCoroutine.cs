using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class SimpleCoroutine : MonoBehaviour
{
    [FormerlySerializedAs("StartEvent")] public UnityEvent startEvent;
    [FormerlySerializedAs("OnEnableEvent")] public UnityEvent onEnableEvent;
    [FormerlySerializedAs("CoroutineEvent")] public UnityEvent coroutineEvent;
    [FormerlySerializedAs("EndCountDownEvent")] public UnityEvent endCountDownEvent;
    [FormerlySerializedAs("StartHoldTime")] public float startHoldTime = 0;
    [FormerlySerializedAs("RepeatHoldTime")] public float repeatHoldTime = 1;
    public bool CanRun { private get; set; }

    private void Start()
    {
        startEvent.Invoke();
    }

    private void OnEnable()
    {
        onEnableEvent.Invoke();
    }

    public void OnStartCoroutine()
    {
        StartCoroutine( RunCoroutine() );
    }
     
    private IEnumerator RunCoroutine()
    {
        CanRun = true;
        yield return new WaitForSeconds(startHoldTime);
        
        while (CanRun)
        {
            coroutineEvent.Invoke();
            yield return new WaitForSeconds(repeatHoldTime);
        } 
    }

    [FormerlySerializedAs("CountDownNum")] public int countDownNum;
    
    public void CountDown()
    {
        countDownNum--;
        if (countDownNum <= 0)
        {
           endCountDownEvent.Invoke();
        }
    }

    public void ResetCountDownNum(int num)
    {
        countDownNum = num;
    }
}
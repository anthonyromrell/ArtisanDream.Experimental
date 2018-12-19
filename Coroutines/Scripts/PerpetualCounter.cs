//using System.Collections;
//using UnityEngine;
//using UnityEngine.Events;
//
//public class PerpetualCounter : MonoBehaviour, IRunCoroutine
//{
//    public UnityEvent OnCount;
//    
//    [SerializeField] private Object holdObject;
//  
//    public Object HoldObject
//    {
//        private get { return holdObject; }
//        set { holdObject = value; }
//    }
//    
//    public IWait HoldObj { private get; set; }
//
//    [SerializeField] private Object waitObject;
//    public Object WaitObject
//    {
//        get => waitObject;
//        set => waitObject = value;
//    }
//
//    public IWait WaitObj { private get; set; }
//    
//    public void OnEnable()
//    {
//        HoldObj = HoldObject as IWait;
//        WaitObj = WaitObject as IWait;
//    }
//
//    public IEnumerator RunCoroutine()
//    {
//        yield return HoldObj.Obj;
//        while (true)
//        {
//            OnCount.Invoke();
//            yield return WaitObj.Obj;
//        }
//    }
//    public void Restart()
//    {
//        StartCoroutine(RunCoroutine());
//    }
//}
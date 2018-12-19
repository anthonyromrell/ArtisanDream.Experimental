using UnityEngine;

public class WaitScript: IWait
{
    public float Seconds { get; set; } = 3;

    public readonly WaitForSeconds Waiter;

    private WaitScript ()
    {
        Waiter = new WaitForSeconds(Seconds);
        Obj = Waiter;
    }

    public object Obj { get; set; }
    public void Create()
    {
        throw new System.NotImplementedException();
    }
}
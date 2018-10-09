using UnityEngine;

public class CallBase<T> : MonoBehaviour, ICallTransform
{
	public void Call(T t)
	{
		if (t is GameObject)
		{
			GetComponent<GameObject>();
		}
	}

	public void Call(Transform obj)
	{
		throw new System.NotImplementedException();
	}

	public void Call()
	{
		throw new System.NotImplementedException();
	}

	public void DoWork()
	{
		throw new System.NotImplementedException();
	}

	public void DoWork<T1>()
	{
		throw new System.NotImplementedException();
	}

	public void DoWork<T1, U>()
	{
		throw new System.NotImplementedException();
	}
}

public class CallObj: CallBase<GameObject>
{
	
}
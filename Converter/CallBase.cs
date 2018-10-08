using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallBase : ScriptableObject, ICall<object>
{
	public void Call(Object T)
	{
		
	}
}

public interface ICall<T>
{
	void Call(Object T);
}
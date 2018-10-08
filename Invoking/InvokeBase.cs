using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InvokeBase : ScriptableObject, IInvoke<Object>
{
	public abstract void Invoke(Object obj);
}

interface IInvoke<T>
{
	void Invoke(T obj);
}
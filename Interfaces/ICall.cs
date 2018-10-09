using UnityEngine;

public interface ICall<T>
{
	void Call();
	void DoWork();
	void DoWork<T>();
	void DoWork<T, U>();
}

interface ICallTransform : ICall<Transform>
{
	void Call(Transform obj);
}  //No error
interface IFebruary<T> : ICall<int> { }  //No error
interface IMarch<T>    : ICall<T> { }    //No error

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RerunBehaviour : MonoBehaviour {

	// Use this for initialization
	public GameAction Action;
	
	public Rerun RerunObj;
	
	void Start ()
	{
		Action.RaiseNoArgs = RaiseNoArgs;
		StartCoroutine(RerunObj.OnRun());
	}

	private void RaiseNoArgs()
	{
		StartCoroutine(RerunObj.OnRun());
	}
}
using UnityEngine;
using UnityEngine.AI;

public abstract class AiBase : ScriptableObject
{
	public FloatBase Speed;
	public FloatBase AngularSpeed;
	public abstract void Navigate(NavMeshAgent ai);
}

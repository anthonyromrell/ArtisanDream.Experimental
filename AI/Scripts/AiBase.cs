using UnityEngine;
using UnityEngine.AI;

public abstract class AiBase : ScriptableObject, IAi
{
	public FloatBase Speed;
	public FloatBase AngularSpeed;
	public abstract void Navigate(NavMeshAgent ai);
}

public interface IAi
{
	
}

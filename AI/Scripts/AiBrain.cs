using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "AiBrain", menuName = "Ai/Brain")]
public class AiBrain : ScriptableObject
{
	public AiBase Base;
	public AiStates.State StartingState;
	public AiStates.State TriggerEnterState;
	public AiStates.State TriggerExitState;
}
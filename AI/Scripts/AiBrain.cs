using UnityEngine;

[CreateAssetMenu(fileName = "AiBrain", menuName = "Ai/Brain")]
public class AiBrain : ScriptableObject
{
	public AiBase Base { get; set; }
	public AiStates.State StartingState;
	public AiStates.State TriggerEnterState;
	public AiStates.State TriggerExitState;
}
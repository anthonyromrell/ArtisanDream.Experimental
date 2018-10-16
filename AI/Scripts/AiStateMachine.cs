using UnityEngine;
using UnityEngine.AI;

public class AiStateMachine : StateMachineBehaviour {

	[HideInInspector]
	public NavMeshAgent Agent;
	public AiBrain CurrentAiBrain;

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		CurrentAiBrain = CreateInstance<AiBrain>();
	}

	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		CurrentAiBrain.Base.Navigate(Agent);
	}
}

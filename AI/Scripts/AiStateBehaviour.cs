using UnityEngine;

public class AiStateBehaviour : StateMachineBehaviour
{
	public AiStateMachine StateMachine;
	
	public AiBase AiBase;

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		StateMachine = animator.GetBehaviour<AiStateMachine>() ;
		StateMachine.CurrentAiBrain.Base = AiBase;
	}
}


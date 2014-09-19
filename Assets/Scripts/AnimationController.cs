using UnityEngine;
using System.Collections;

public enum AnimationStates{
	Walk,
	Run,
	Iddle
}

public class AnimationController : MonoBehaviour {

	public Animator animator;



	public void PlayAnimation(AnimationStates stateAnimation){
		switch (stateAnimation) {
		case AnimationStates.Iddle:
			StopAnimations();
			animator.SetBool("InIddle", true);
			break;
		case AnimationStates.Walk:
			StopAnimations();
			animator.SetBool("InWalk", true);
			break;
		case AnimationStates.Run:
			StopAnimations();
			animator.SetBool("InRun", true);
			break;
		}
	}

	void StopAnimations(){
		animator.SetBool("InIddle", false);
		animator.SetBool("InWalk", false);
		animator.SetBool("InRun", false);
	}
}

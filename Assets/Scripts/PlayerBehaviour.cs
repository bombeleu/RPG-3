using UnityEngine;
using System.Collections;

public enum TypeCharacter{
	Warrior = 0,
	Wizard = 1,
	Archer = 2
}

public class PlayerBehaviour : CharacterBase {

	private TypeCharacter type;

	private AnimationController animationController;

	//Movimentation
	private float speed = 3.0f;
	public float speedRun;
	public float speedWalk;
	public float rotateSpeed = 3.0f;


	// Use this for initialization
	void Start () {
		base.Start ();
		currentLevel = PlayerStatsController.GetCurrentLevel();
		type = PlayerStatsController.GetTypeCharacter ();

		basicStats = PlayerStatsController.instance.GetBasicStats (type);

		animationController = GetComponent<AnimationController> ();

		speed = speedWalk;

	}
	
	// Update is called once per frame
	void Update () {
		base.Update ();

		if (Input.GetKey (KeyCode.LeftShift)) {
			speed = speedRun;
			animationController.PlayAnimation(AnimationStates.Run);
		}else{
			speed = speedWalk;
			if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
				animationController.PlayAnimation(AnimationStates.Walk);
			else
				animationController.PlayAnimation(AnimationStates.Iddle);
		}


		CharacterController controller = GetComponent<CharacterController> ();
		transform.Rotate (0, Input.GetAxis ("Horizontal") * rotateSpeed, 0);
		Vector3 forward = transform.TransformDirection (Vector3.forward);
		float curSpeed = speed * Input.GetAxis ("Vertical");
		controller.SimpleMove (forward * curSpeed);
	}
}

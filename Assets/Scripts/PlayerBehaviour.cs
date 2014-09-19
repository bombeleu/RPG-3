using UnityEngine;
using System.Collections;

public enum TypeCharacter{
	Warrior = 0,
	Wizard = 1,
	Archer = 2
}

public class PlayerBehaviour : CharacterBase {

	private TypeCharacter type;


	// Use this for initialization
	void Start () {
		base.Start ();
		currentLevel = PlayerStatsController.GetCurrentLevel();
		type = PlayerStatsController.GetTypeCharacter ();

		basicStats = PlayerStatsController.instance.GetBasicStats (type);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

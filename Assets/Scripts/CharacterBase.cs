using UnityEngine;
using System.Collections;

[System.Serializable]
public class BasicStats{
	public float startLife;
	public float startMana;
	public int strenght;
	public int magic;
	public int agillity;
	public int baseDefense;
	public int baseAttack;
}

public abstract class CharacterBase : MonoBehaviour {

	//basics Attrributs
	public int currentLevel;
	public BasicStats basicStats;

	// Use this for initialization
	protected void Start () {

	}

	// Update is called once per frame
	protected void Update () {
	
	}
}

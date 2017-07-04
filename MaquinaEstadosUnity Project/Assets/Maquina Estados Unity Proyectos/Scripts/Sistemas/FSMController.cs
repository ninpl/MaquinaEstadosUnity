using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MinerController))]
public class FSMController : MonoBehaviour {

	State prevState;
	State currentState;
	public MinerController player;


	void Start()
	{
		player = this.GetComponent<MinerController>();
		currentState = new EnterMine(this);
	}

	void Update()
	{
		player.sed += 1;
		player.cansancio += 1;
		currentState.Execute();
	}

	public void ChangeState(State newState)
	{
		prevState = currentState;
		currentState.Exit();
		currentState = newState;
		currentState.Enter();
	}
}

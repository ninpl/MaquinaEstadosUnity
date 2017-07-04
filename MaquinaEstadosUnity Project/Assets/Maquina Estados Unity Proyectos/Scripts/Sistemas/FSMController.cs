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
		currentState = new EnterMine();
	}

	void Update()
	{
		currentState.Execute();
	}

	public void ChangeState(State newState)
	{
		prevState = currentState;
		currentState = newState;
	}
}

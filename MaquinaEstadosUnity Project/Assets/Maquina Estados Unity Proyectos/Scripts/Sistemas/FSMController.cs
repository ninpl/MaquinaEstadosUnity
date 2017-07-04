using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMController : MonoBehaviour {

	State currentState;


	void Start()
	{
		currentState = new EnterMine();
	}

	void Update()
	{
		currentState.Execute();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase Abstracta : Solo con metodos abstractos, obliga a tener los metodos en todas las
// clases que hereden de state
public abstract class State
{
	public FSMController FSM;

	// Constructor
	public State(FSMController obj)
	{
		FSM = obj;
	}

	public abstract void Execute ();
}

public class EnterMine : State
{

	public EnterMine(FSMController obj) : base(obj)
	{

	}

	public override void Execute()
	{
		Debug.Log("Mine");

		FSM.player.oro += 3;

		if(FSM.player.oro >= 100)
		{
			FSM.ChangeState(new VisitBank(FSM));
		}
	}
}

public class VisitBank : State
{
	public VisitBank(FSMController obj) : base(obj)
	{

	}


	public override void Execute()
	{
		Debug.Log("Bank");
		FSM.player.oro -= 3;
		FSM.player.monedas += 2;
	}
}

public class Quench : State
{
	public Quench(FSMController obj) : base(obj)
	{

	}

	public override void Execute()
	{
		Debug.Log("Quench");
		FSM.player.sed -= 5;
	}
}

public class GoHome : State
{
	public GoHome(FSMController obj) : base(obj)
	{

	}

	public override void Execute()
	{
		Debug.Log("Home");
		FSM.player.cansancio -= 5;
	}
}
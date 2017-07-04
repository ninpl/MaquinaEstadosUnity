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
	public abstract void Enter (){}
	public abstract void Exit (){}
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

		if(FSM.player.sed >= 150)
		{
			FSM.ChangeState(new Quench(FSM));
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

		if(FSM.player.oro > 0) return;

		if(FSM.player.monedas >= 100)
		{
			FSM.ChangeState(new GoHome(FSM));
		}

		if(FSM.player.monedas <= 100)
		{
			FSM.ChangeState(new EnterMine(FSM));
		}
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

		if(FSM.player.sed <= 0)
		{
			FSM.ChangeState(new EnterMine(FSM));
		}
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

		if(FSM.player.cansancio <= 0)
		{
			FSM.ChangeState(new EnterMine(FSM));
		}
	}
}
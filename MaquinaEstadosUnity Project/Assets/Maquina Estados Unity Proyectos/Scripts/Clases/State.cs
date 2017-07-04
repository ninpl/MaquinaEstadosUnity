using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase Abstracta : Solo con metodos abstractos, obliga a tener los metodos en todas las
// clases que hereden de state
public abstract class State
{
	public abstract void Execute ();
}

public class EnterMine : State
{
	public override void Execute()
	{
		Debug.Log("Mine");
	}
}

public class VisitBank : State
{
	public override void Execute()
	{
		Debug.Log("Bank");
	}
}

public class Quench : State
{
	public override void Execute()
	{
		Debug.Log("Quench");
	}
}

public class GoHome : State
{
	public override void Execute()
	{
		Debug.Log("Home");
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinerAnimatorController : MonoBehaviour {

	MinerController player;
	Animator anim;

	// Use this for initialization
	void Start () {
		player = this.GetComponent<MinerController>();
		anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetInteger("Oro", player.oro);
		anim.SetInteger("Cansancio", player.cansancio);
		anim.SetInteger("Dinero", player.monedas);
		anim.SetInteger("Sed", player.sed);
	}
}

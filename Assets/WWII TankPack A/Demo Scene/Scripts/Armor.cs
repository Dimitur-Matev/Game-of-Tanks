﻿using UnityEngine;
using System.Collections;

public class Armor : MonoBehaviour {

	public int armor;
	public TankHealth tankHealthManager;


	void Start () {

	}
	
	// Update is called once per frame
//	void Update () {
//	
//	}

	void OnCollisionEnter(Collision collision){
		if(!tankHealthManager.isDead()){
			Shell shell = collision.collider.GetComponent<Shell>();
			// get the angle of the collision 
			// get the collider that colides with the armor
			// get the angle ot the collision (bounse or not)
			// generate number (for example from 300 to 410) for the dmg (this depends on the shell)
			tankHealthManager.subtractTankHealth(shell.armorPenetrationMM);
		}
	}
}
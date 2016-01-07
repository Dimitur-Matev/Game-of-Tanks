﻿using UnityEngine;
using System.Collections;

public class Shell : MonoBehaviour {
	
	
	private float speed = 200;
	private float range = 400;
	public int armorPenetrationMM = 100;	
	public GameObject ExploPtcl;
	
	private float dist;
	
	void  Update (){

		// Move Ball forward
		transform.Translate(Vector3.forward * Time.deltaTime * speed);
		
		// Record Distance.
		dist += Time.deltaTime * speed;
		
		// If reach to my range, Destroy. 
		if(dist >= range) {
			Instantiate(ExploPtcl, transform.position, transform.rotation);
			Destroy(gameObject);
		}
	}
	
	
	void  OnTriggerEnter ( Collider other  ){
		// If hit something, Destroy. 
		Instantiate(ExploPtcl, transform.position, transform.rotation);
		Destroy(gameObject);
	}
	
}
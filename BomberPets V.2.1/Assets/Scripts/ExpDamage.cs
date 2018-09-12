﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpDamage : MonoBehaviour {

	public static int damage;
	public AudioSource expSound;

	// Use this for initialization
	void Start () {
		damage = 1;
		expSound.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D coll) 
	{
		if (coll.gameObject.CompareTag("Destructible"))
		{
			Destroy(coll.gameObject);
		}
	}
}
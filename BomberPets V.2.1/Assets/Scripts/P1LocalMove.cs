﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1LocalMove : MonoBehaviour {

    private Rigidbody2D rb;
    
	public static float speedP1;
	public static int healthP1;

	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody2D>(); 
		healthP1 = 3;
        Time.timeScale = 1f;
		speedP1 = 8;
	}
	
	// Update is called once per frame
	void Update () {
		if (healthP1 <= 0) {
			Destroy (gameObject);
            SingleVictoryManager.defeat = true;
		}
	}

	void FixedUpdate()
    {
		
     rb.velocity = new Vector2(Input.GetAxis("HorizontalP1") * speedP1, Input.GetAxis("VerticalP1") * speedP1);   
        
    }


	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.CompareTag("Explosion"))
		{
			healthP1 = healthP1 - ExpDamage.damage;
			Debug.Log (healthP1  + " p1");
		}

       
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Enemy"))
        {
            healthP1 = healthP1 - 1;

        }
    }
}
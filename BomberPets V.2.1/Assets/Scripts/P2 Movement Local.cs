using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2LocalMove : MonoBehaviour {

	// Use this for initialization
	 private Rigidbody2D rb;
    public static float speedP2;
	public static int healthP2;
	void Start () {
		rb = GetComponent <Rigidbody2D>(); 
		healthP2 = 3;
		speedP2 = 8;
	}
	
	// Update is called once per frame
	void Update () {
		if (healthP2 <= 0) {
			Destroy (gameObject);
		}
	}

	void FixedUpdate()
	{
      rb.velocity = new Vector2(Input.GetAxis("HorizontalP2") * speedP2, Input.GetAxis("VerticalP2") * speedP2);

	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.CompareTag("Explosion"))
		{
			healthP2 = healthP2 - ExpDamage.damage;
			Debug.Log (healthP2 + " p2");
		}
	}
}

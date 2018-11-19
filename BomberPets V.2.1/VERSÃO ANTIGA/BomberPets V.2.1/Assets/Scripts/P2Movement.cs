using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Movement : MonoBehaviour {

    private Rigidbody2D rb;
    public float speed;
	public static int healthP2;

	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody2D>(); 
		healthP2 = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if (healthP2 <= 0) {
			Destroy (gameObject);
		}
	}

	void FixedUpdate()
	{
      rb.velocity = new Vector2(Input.GetAxis("HorizontalP2") * speed, Input.GetAxis("VerticalP2") * speed);

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

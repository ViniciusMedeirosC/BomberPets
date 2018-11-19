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
		speedP2 = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if (healthP2 <= 0) {
			Destroy (gameObject);
		}

        
	}

	void FixedUpdate()
	{
        //rb.velocity = new Vector2(Input.GetAxis("HorizontalP2") * speedP2, Input.GetAxis("VerticalP2") * speedP2);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-speedP2, 0);
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(speedP2, 0);
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(0, speedP2);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(0, - speedP2);
        }


       //if(rb.velocity == 0)
       //{
       //   float x = Mathf.Round(transform.position.x);
       //     float y = Mathf.Round(transform.position.y);


       // }

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

	Transform trans;
	public float friction = 0.5f;
	public float length = 2f;
	Rigidbody2D rb2d;

	//Names
	string topWall = "TopCollider";
	string bottomwall = "BottomCollider";
	string player = "Player";
	string computerAI = "ComputerAI";

	// Use this for initialization

	void Start () {
		rb2d = GetComponent <Rigidbody2D> ();
		trans = GetComponent <Transform> ();
		rb2d.freezeRotation = true;
	}
	 
	void OnCollisionEnter2D(Collision2D coll) {
		if(coll.gameObject.name == player || coll.gameObject.name == computerAI){
			float objectY = coll.gameObject.transform.position.y;
			float ballY = trans.position.y;
			float diffy = objectY - ballY;
			SpriteRenderer spriteRend = coll.gameObject.GetComponent <SpriteRenderer>();
			diffy /= spriteRend.sprite.bounds.extents.y;
			diffy = Mathf.Clamp (diffy, -0.85f, 0.85f);


			float velx = rb2d.velocity.x;
			float vely = rb2d.velocity.y;
			float diffx = 1 - (diffy * diffy);

			if (rb2d.velocity.x > 0)
				diffx = Mathf.Sqrt (diffx);
			else
				diffx = -Mathf.Sqrt (diffx);

			Vector2 direction = new Vector2 (-diffx, -diffy);
			float magnitude = rb2d.velocity.magnitude;
			//rb2d.velocity = new Vector2(-rb2d.velocity.x,rb2d.velocity.y);
			rb2d.velocity = direction * magnitude;
		}
			
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.name == topWall || coll.gameObject.name == bottomwall)
			rb2d.velocity = new Vector2 (rb2d.velocity.x, -rb2d.velocity.y);
	}
}

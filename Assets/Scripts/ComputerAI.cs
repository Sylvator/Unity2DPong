using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerAI : MonoBehaviour {

	Rigidbody2D rb2d;
	public float speed=500f;
	public GameObject ball;
	string ballName = "Ball";
	Transform trans;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent <Rigidbody2D> ();
		ball = GameObject.Find (ballName);
		trans = GetComponent <Transform> ();
		rb2d.freezeRotation = true;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float ball_y = ball.transform.position.y;
		float ball_x = ball.transform.position.x;
		//print ("ball y position: " + ball_y);
		//print ("player y position" + trans.position.y);
		if (ball_y > trans.position.y)
			rb2d.velocity = new Vector2 (0, speed * Time.fixedDeltaTime);
		else if (ball_y < trans.position.y)
			rb2d.velocity = new Vector2 (0, -speed * Time.fixedDeltaTime);
		else
			rb2d.velocity = Vector2.zero;
			
	}
}

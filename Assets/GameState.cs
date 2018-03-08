using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour {

	GameObject ball;
	public Vector3 startPos = new Vector3(0,0,0);
	public float startSpeedx = 3f;
	public float startSpeedy = -3f;
	// Use this for initialization
	void Start () {
		ball = GameObject.Find ("Ball");
	}
	
	void Update () {
		if (ball.transform.position.x < -4){
			print ("Player Lost!");
			GameObject ball = GameObject.Find ("Ball");
			ball.transform.position = startPos;
			Rigidbody2D rb2d = ball.GetComponent<Rigidbody2D> ();
			rb2d.velocity = new Vector2 (startSpeedx, startSpeedy);
		}
		if(ball.transform.position.x > 4){
			print ("Player Won!");
			GameObject ball = GameObject.Find ("Ball");
			ball.transform.position = startPos;
			Rigidbody2D rb2d = ball.GetComponent<Rigidbody2D> ();
			rb2d.velocity = new Vector2 (startSpeedx, startSpeedy);
		}
	}
}

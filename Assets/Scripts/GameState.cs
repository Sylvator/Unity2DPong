using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour {

	GameObject ball;
	public Vector3 startPos = new Vector3(0,0,0);


	// Use this for initialization
	void Start () {
		ball = GameObject.Find ("Ball");
		initBall ();
		
	}
	
	void Update () {
		
		if (ball.transform.position.x < -4){
			print ("Player Lost!");
			initBall ();
		}
		if(ball.transform.position.x > 4){
			print ("Player Won!");
			initBall ();

		}

	}

	void initBall() {
		GameObject ball = GameObject.Find ("Ball");
		ball.transform.position = startPos;
		Rigidbody2D rb2d = ball.GetComponent<Rigidbody2D> ();
		float startDirX = Random.Range (0.3f,0.7f);
		float startDirY = 1 - (startDirX * startDirX);
		rb2d.velocity = 5 * new Vector2 (startDirX, startDirY);
	}
}

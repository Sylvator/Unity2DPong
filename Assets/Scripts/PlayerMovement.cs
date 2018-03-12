using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed = 1.0f;
	public Rigidbody2D rb2d;
	public Transform trans;


	// Use this for initialization
	void Start () {
		rb2d = GetComponent <Rigidbody2D> ();
		trans = GetComponent<Transform> ();
		rb2d.freezeRotation = true;

	}
	void FixedUpdate () {

		int dir = (int) Input.GetAxisRaw ("Vertical");
		int touchdir = 0;

		if(Input.touchCount >0) {
			Touch touch = Input.GetTouch (0);
			if (touch.position.y < Screen.height / 2)
				touchdir = -1;
			else
				touchdir = 1;
		}
		Vector2 move = new Vector2(0,dir * speed * Time.fixedDeltaTime + touchdir * speed * Time.fixedDeltaTime);

		if (trans.position.y < 4 && (dir == 1 || touchdir == 1))
			rb2d.velocity = move;
		else if (trans.position.y > -4 && (dir == -1 || touchdir == -1))
			rb2d.velocity = move;
		else
			rb2d.velocity = Vector2.zero;
	}
}

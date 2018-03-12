using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private static GameManager _instance;

	public static GameManager Instance {
		get{return _instance;}
	}

	// Use this for initialization
	void Awake () {
		if (_instance != null && _instance != this){
			Destroy (this.gameObject);
			return;
		}
		_instance = this;
		DontDestroyOnLoad (gameObject);
	}

}

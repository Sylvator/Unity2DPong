using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	private static AudioManager _instance;

	public static AudioManager Instance {
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

	void playBGMusic(AudioSource bgm) {
		bgm.Play ();
	}
}

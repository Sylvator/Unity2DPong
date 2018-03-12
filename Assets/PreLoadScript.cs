using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreLoadScript : MonoBehaviour {

	public GameObject gameManager;
	public GameObject audioManager;

	void Awake() {
		Screen.orientation = ScreenOrientation.AutoRotation;

		if (GameManager.Instance == null)
			Instantiate (gameManager);

		if (AudioManager.Instance == null)
			Instantiate (audioManager);
			
	}
}

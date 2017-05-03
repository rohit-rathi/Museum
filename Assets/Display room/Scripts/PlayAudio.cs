using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAudio : MonoBehaviour {

	public AudioClip[] soundFiles;
	public AudioSource soundSource;
	public GameObject canvas;

	// Use this for initialization
	void Start () {
		soundSource.clip = soundFiles [0];
		soundSource.Play ();
		Invoke ("LoadMuseumScene", soundSource.clip.length + 3);
	}
				
	public void LoadMuseumScene() {
		SceneManager.LoadScene ("Scene");
	}
}

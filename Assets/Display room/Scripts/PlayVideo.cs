using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]

public class PlayVideo : MonoBehaviour {

	public MovieTexture movie;
	private AudioSource audio;
	private bool isPlaying = false;

	// Use this for initialization
	void Start () {
		GetComponent<RawImage> ().texture = movie as MovieTexture;
		audio = GetComponent<AudioSource> ();
		audio.clip = movie.audioClip;
		//movie.Play ();
		//audio.Play ();

	}

	public void changeStatusOfMovie ()
	{
		if (isPlaying) {
			movie.Pause ();
			audio.Pause ();
			Debug.Log ("pausing");
		} 
		else {
			movie.Play ();
			audio.Pause ();
			Debug.Log ("playing");
		}
		isPlaying = !isPlaying;
		
	}
}
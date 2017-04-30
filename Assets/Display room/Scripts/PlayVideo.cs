using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]

public class PlayVideo : MonoBehaviour {

	public MovieTexture movie;
	private AudioSource audio;
	private static bool isPlaying = false;
	private GameObject light;

	// Use this for initialization
	void Start () {
		GetComponent<RawImage> ().texture = movie as MovieTexture;
		audio = GetComponent<AudioSource> ();
		audio.clip = movie.audioClip;
		light = GameObject.Find ("Directional light");

	}

	public void changeStatusOfMovie ()
	{
		if (!isPlaying) {
			TurnLightOff (light);
			movie.Play ();
			audio.Play ();
			isPlaying = true;
			Invoke ("IsVideoPlayingFalse", audio.clip.length);
		}
	}

	private void IsVideoPlayingFalse() {
		isPlaying = false;
	}

	public static bool IsVideoPlaying () {
		return isPlaying;
	}

	public static void TurnLightOff(GameObject light){
		light.SetActive(false);
	}

	public static void TurnLightOn(GameObject light) {
		light.SetActive(true);
	}
}
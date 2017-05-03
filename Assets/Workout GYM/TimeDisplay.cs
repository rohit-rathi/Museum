using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {

	Text text;
	BallSpawner spawner;

	// Use this for initialization
	void Start () {
		text = FindObjectOfType<Text> ();
		spawner = FindObjectOfType<BallSpawner> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Time: " + spawner.GetTimeTillOver ();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeRemainingDisplay : MonoBehaviour {

	Text text;
	BallSpawner bs;

	// Use this for initialization
	void Start () {
		bs = FindObjectOfType<BallSpawner> ();
		text = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		text.text = "Time: " + bs.GetTimeTillOver();
	}
}

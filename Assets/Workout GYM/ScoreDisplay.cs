using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

	Text text;
	ScoreKeeper sc;

	// Use this for initialization
	void Start () {
		sc = FindObjectOfType<ScoreKeeper> ();
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score: " + sc.GetScore ();
	}
}

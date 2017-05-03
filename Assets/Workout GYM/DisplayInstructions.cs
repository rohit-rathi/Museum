using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInstructions : MonoBehaviour {

	public GameObject instructions;
	private bool startTimer = false;

	// Use this for initialization
	void Start () {
		instructions.SetActive (true);
	}

	public void ReadyToPlay() {
		instructions.SetActive (false);
		startTimer = true;
	}

	public bool StartTimer() {
		return startTimer;
	}
}

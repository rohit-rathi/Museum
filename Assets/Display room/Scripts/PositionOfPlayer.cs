using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionOfPlayer : MonoBehaviour {

	public GameObject camera;
	public GameObject canvasThree;

	void Awake() {
		//if(camera.transform.position == canvsThree.position)
		camera.transform.position = new Vector3 ();
	}
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (camera);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

	public GameObject ballPrefab;
	public float speed = 5.0f;
	private float timeTillGameIsOver = 30.0f; 
	private DisplayInstructions di;
	public GameObject returnHome;

	// Use this for initialization
	void Start () {
		di = FindObjectOfType<DisplayInstructions> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (timeTillGameIsOver > 0 && di.StartTimer()) {
			if (GvrViewer.Instance.Triggered) {	
				Debug.Log("FIRING");
				GameObject instance = Instantiate (ballPrefab);
				instance.transform.position = transform.position;
				Rigidbody rb = instance.GetComponent<Rigidbody> ();
				rb.velocity = transform.rotation * Vector3.forward * speed;
			}

			timeTillGameIsOver -= Time.deltaTime;

			if (timeTillGameIsOver <= 0) {
				timeTillGameIsOver = 0.00f;
				InstantiateMenuSystem();
			}
		}
	}

	public string GetTimeTillOver() {
		return timeTillGameIsOver.ToString("F2");
	}

	public void InstantiateMenuSystem() {
		returnHome.SetActive(true);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComponents : MonoBehaviour {

	public static void MakeCanvasAppear(GameObject canvas) {
		canvas.SetActive (true);
	}

	public static void MakeCanvasDisappear(GameObject canvas) {
		canvas.SetActive (false);
	}
}

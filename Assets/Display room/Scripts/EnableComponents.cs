using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComponents : MonoBehaviour {

	public static void MakeHoloFitCanvasAppear(GameObject canvas) {
		canvas.SetActive (true);
	}

	public static void MakeHoloFitCanvasDisappear(GameObject canvas) {
		canvas.SetActive (false);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	// used for the various position that the player can be at 
	public GameObject StartPosition;
	public GameObject PositionOneCanvas;
	public GameObject PositionTwoCanvas;
	public GameObject PositionThreeCanvas;
	public GameObject CanvasThreeHalfPosition;
	public GameObject PositionFourCanvas;
	public GameObject PositionFiveCanvas;
	public GameObject EndPosition;

	public GameObject player;

	public GameObject HoloFitCanvas;
	public GameObject HealthProblemCanas;

	private GameObject light;

	// Use this for initialization
	void Start () {
		player.transform.position = StartPosition.transform.position;
		player.transform.Rotate (0, 180, 0, Space.World);
		light = GameObject.Find ("Directional light");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MoveToFirstCanvas() {
		iTween.MoveTo (player, PositionOneCanvas.transform.position, 1.5f);
	}

	public void MoveToSecondCanvas() {
		iTween.MoveTo (player, PositionTwoCanvas.transform.position, 1.5f);
		EnableComponents.MakeHoloFitCanvasAppear (HealthProblemCanas);

	}

	public void MoveToThirdCanvas() {
		if (!DangerVideo.IsVideoPlaying()) {
			iTween.MoveTo (player, PositionThreeCanvas.transform.position, 1.5f);
			EnableComponents.MakeHoloFitCanvasDisappear(HealthProblemCanas);
			DangerVideo.TurnLightOn (light);
		}
	}

	public void MoveToThirdHalfCanvas() {
		iTween.MoveTo (player, CanvasThreeHalfPosition.transform.position, 1.5f);
	}
		
	public void MoveToFourthCanvas() {
		iTween.MoveTo (player, PositionFourCanvas.transform.position, 1.5f);
		EnableComponents.MakeHoloFitCanvasAppear (HoloFitCanvas);
	}

	public void MoveToFifthCanvas() {
		if (!PlayVideo.IsVideoPlaying()) {
			iTween.MoveTo (player, PositionFiveCanvas.transform.position, 1.5f);
			EnableComponents.MakeHoloFitCanvasDisappear(HoloFitCanvas);
			PlayVideo.TurnLightOn (light);
		}
	}

	public void MoveToEnd() {
		iTween.MoveTo (player, EndPosition.transform.position, 1.5f);
	}
}

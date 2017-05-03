using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


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

	// the various canvasses used
	public GameObject HoloFitCanvas;
	public GameObject HealthProblemCanas;
	public GameObject EnterGymCanvas;
	public GameObject DisplayIntroCanvas;
	public GameObject PlayBasketballCanvas;
	public GameObject MoveToThreeHalfCanvas;
	public GameObject MoveToFour;
	public GameObject StartTourCanvas;
	public GameObject WhatThisIsAboutCanvas;
	public GameObject ResetTourCanvas;

	public PersistantObject determinePositionOfCamera;

	// Use this for initialization
	void Start () {
		if (determinePositionOfCamera.GetCount () == 0) {
			EnableComponents.MakeCanvasAppear (StartTourCanvas);
			player.transform.position = StartPosition.transform.position;
			determinePositionOfCamera.IncrementCount ();
		} 

		else if (determinePositionOfCamera.GetCount () == 1) {
			player.transform.position = PositionThreeCanvas.transform.position;
			player.transform.eulerAngles = new Vector3 (0, -180, 0);
			EnableComponents.MakeCanvasAppear (MoveToThreeHalfCanvas);
			determinePositionOfCamera.IncrementCount ();
		} 

		else {
			EnableComponents.MakeCanvasAppear (ResetTourCanvas);
			player.transform.position = PositionFiveCanvas.transform.position;
		}		
		DontDestroyOnLoad(determinePositionOfCamera);
	}

	public void MoveToFirstCanvas() {
		iTween.MoveTo (player, PositionOneCanvas.transform.position, 1.5f);
		EnableComponents.MakeCanvasAppear (DisplayIntroCanvas);
		EnableComponents.MakeCanvasDisappear (StartTourCanvas);
	}

	public void MoveToSecondCanvas() {
		iTween.MoveTo (player, PositionTwoCanvas.transform.position, 1.5f);
		EnableComponents.MakeCanvasAppear (HealthProblemCanas);
		EnableComponents.MakeCanvasDisappear(DisplayIntroCanvas);
	}

	public void MoveToThirdCanvas() {
		if (!DangerVideo.IsVideoPlaying()) {
			iTween.MoveTo (player, PositionThreeCanvas.transform.position, 1.5f);
			EnableComponents.MakeCanvasDisappear(HealthProblemCanas);
			EnableComponents.MakeCanvasAppear (EnterGymCanvas);
		}
	}

	public void MoveToThirdHalfCanvas() {
		iTween.MoveTo (player, CanvasThreeHalfPosition.transform.position, 1.5f);
		EnableComponents.MakeCanvasDisappear (MoveToThreeHalfCanvas);
		EnableComponents.MakeCanvasAppear (MoveToFour);

	}
		
	public void MoveToFourthCanvas() {
		iTween.MoveTo (player, PositionFourCanvas.transform.position, 1.5f);
		EnableComponents.MakeCanvasAppear (HoloFitCanvas);
		EnableComponents.MakeCanvasDisappear(MoveToFour);

	}

	public void MoveToFifthCanvas() {
		if (!PlayVideo.IsVideoPlaying()) {
			iTween.MoveTo (player, PositionFiveCanvas.transform.position, 1.5f);
			EnableComponents.MakeCanvasDisappear(HoloFitCanvas);
			EnableComponents.MakeCanvasAppear (PlayBasketballCanvas);
		}
	}

	public void MoveToEnd() {
		EnableComponents.MakeCanvasDisappear (PlayBasketballCanvas);
		iTween.MoveTo (player, EndPosition.transform.position, 1.5f);
	}

	public void LoadGymScene() {
		EnableComponents.MakeCanvasDisappear (EnterGymCanvas);
		SceneManager.LoadScene ("WorkoutGYM");
	}

	public void LoadBasketballScene() {
		SceneManager.LoadScene ("BasketBall");
	}

	public void DisplayWhatThisIsAboutCanvas() {
		EnableComponents.MakeCanvasAppear (WhatThisIsAboutCanvas);
	}

	public void ResetTour() {
		EnableComponents.MakeCanvasAppear (StartTourCanvas);
		player.transform.position = StartPosition.transform.position;		
		EnableComponents.MakeCanvasDisappear (ResetTourCanvas);
		PersistantObject po = FindObjectOfType<PersistantObject> ();
		po.SetCountToOne ();
	}
}

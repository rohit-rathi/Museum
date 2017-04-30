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

	private GameObject light;

	// Use this for initialization
	void Start () {
		player.transform.position = StartPosition.transform.position;
		player.transform.Rotate (0, 180, 0, Space.World);
		light = GameObject.Find ("Directional light");
		// instantiate a canvas infront of you saying start game
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MoveToFirstCanvas() {
		iTween.MoveTo (player, PositionOneCanvas.transform.position, 1.5f);
		EnableComponents.MakeCanvasAppear (DisplayIntroCanvas);

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
			DangerVideo.TurnLightOn (light);
			EnableComponents.MakeCanvasAppear (EnterGymCanvas);
		}
	}

	public void MoveToThirdHalfCanvas() {
		iTween.MoveTo (player, CanvasThreeHalfPosition.transform.position, 1.5f);
		EnableComponents.MakeCanvasDisappear (EnterGymCanvas);
	}
		
	public void MoveToFourthCanvas() {
		iTween.MoveTo (player, PositionFourCanvas.transform.position, 1.5f);
		EnableComponents.MakeCanvasAppear (HoloFitCanvas);
	}

	public void MoveToFifthCanvas() {
		if (!PlayVideo.IsVideoPlaying()) {
			iTween.MoveTo (player, PositionFiveCanvas.transform.position, 1.5f);
			EnableComponents.MakeCanvasDisappear(HoloFitCanvas);
			PlayVideo.TurnLightOn (light);
			EnableComponents.MakeCanvasAppear (PlayBasketballCanvas);
		}
	}

	public void MoveToEnd() {
		EnableComponents.MakeCanvasDisappear (PlayBasketballCanvas);
		iTween.MoveTo (player, EndPosition.transform.position, 1.5f);
	}

	public void LoadGymScene() {
		SceneManager.LoadScene ("WorkoutGYM");
	}

	public void LoadBasketballScene() {
		SceneManager.LoadScene ("BasketBall");
	}
}

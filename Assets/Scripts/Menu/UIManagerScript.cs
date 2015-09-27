using UnityEngine;
using System.Collections;

public class UIManagerScript : MonoBehaviour {

	public void StartGame() {
		Application.LoadLevel("GameScene");
	}

	public void ExitGame() {
		Application.Quit();
	}
}

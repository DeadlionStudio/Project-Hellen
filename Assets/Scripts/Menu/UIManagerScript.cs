using UnityEngine;
using System.Collections;

public class UIManagerScript : MonoBehaviour {

	public Animator startButton;
	public Animator settingsButton;
	public Animator settingDialog;

	public void StartGame() {
		Application.LoadLevel ("GameScene");
	}

	public void ExitGame() {
		Application.Quit();
	}

	public void OpenSettings() {
		startButton.SetBool ("isHidden", true);
		settingsButton.SetBool ("isHidden", true);
		settingDialog.enabled = true;
		settingDialog.SetBool ("isHidden", false);
	}

	public void CloseSettings() {
		settingDialog.SetBool ("isHidden", true);
		startButton.SetBool ("isHidden", false);
		settingsButton.SetBool ("isHidden", false);
	}
}

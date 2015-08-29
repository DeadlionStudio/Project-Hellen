using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	void OnGUI () {
		Application.LoadLevel ("GameScene");
	}
}

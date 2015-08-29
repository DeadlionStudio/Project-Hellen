using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	void OnGUI () {
	
		if (Input.GetMouseButtonDown(0)) {
			Application.LoadLevel ("GameScene");
		}
	}
}

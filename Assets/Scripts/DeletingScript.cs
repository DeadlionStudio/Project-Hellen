using UnityEngine;
using System.Collections;

public class DeletingScript : MonoBehaviour {
	
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider myTrigger) {
		GameObject triggerObj = myTrigger.gameObject;
		triggerObj.GetComponent<DragNDrop> ().IsMouseTriger = true;

		if (triggerObj.name == "Souls" || triggerObj.name == "Souls(Clone)") {
			Rigidbody rigidbody = triggerObj.GetComponent<Rigidbody>();
			GameObject camera = GameObject.Find("Main Camera");

			if (name == "Hell") {
				rigidbody.AddForce(new Vector3(0, -500f, 0));
				camera.GetComponent<StatisticScript>().addSoulToHell(triggerObj);
			}

			if (name == "Heaven") {
				rigidbody.AddForce(new Vector3(0, 500f, 0));
				camera.GetComponent<StatisticScript>().addSoulToHeaven(triggerObj);
			}

			Destroy(triggerObj, 5.0f);
		}
	}
}

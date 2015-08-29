using UnityEngine;
using System.Collections;

public class DeletingScript : MonoBehaviour {

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay(Collider myTrigger) {
		GameObject triggerObj = myTrigger.gameObject;
		if (triggerObj.name == "Souls" || triggerObj.name == "Souls(Clone)") {
			Rigidbody rigidbody = triggerObj.GetComponent<Rigidbody>();
			GameObject camera = GameObject.Find("Main Camera");

			if (name == "Hell") {
				triggerObj.GetComponent<DragNDrop>().IsMouseTriger = true;
				rigidbody.AddForce(new Vector3(0, -8, 0));
				camera.GetComponent<StatisticScript>().addSoulToHell(triggerObj);
			}

			if (name == "Heaven") {
				triggerObj.GetComponent<DragNDrop>().IsMouseTriger = true;
				rigidbody.AddForce(new Vector3(0, 8, 0));
				camera.GetComponent<StatisticScript>().addSoulToHeaven(triggerObj);
			}
			if (triggerObj.GetComponent<DragNDrop>().IsMouseUp) {
				Destroy(triggerObj, 3f);
			}
		}
	}

}

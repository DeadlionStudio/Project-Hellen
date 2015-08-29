using UnityEngine;
using System.Collections;

public class DeletingScript : MonoBehaviour {

	bool isDestroyStart = false;

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
			if (name == "Hell" || name == "Heaven") {
				triggerObj.GetComponent<DragNDrop>().IsMouseTriger = true;
			}
			if (triggerObj.GetComponent<DragNDrop>().IsMouseUp) {

				if (name == "Hell") {
					if (isDestroyStart == false) {
						isDestroyStart = true;
						camera.GetComponent<StatisticScript>().addSoulToHell(triggerObj);
					}
					rigidbody.AddForce(new Vector3(0, -8, 0));
				}

				if (name == "Heaven") {
					if (isDestroyStart == false) {
						isDestroyStart = true;
						camera.GetComponent<StatisticScript>().addSoulToHeaven(triggerObj);
					}
					rigidbody.AddForce(new Vector3(0, 8, 0));
				}

				Destroy(triggerObj, 3f);
			}
		}
	}

}

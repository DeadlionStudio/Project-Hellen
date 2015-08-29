using UnityEngine;
using System.Collections;

public class DeletingScript : MonoBehaviour {
	
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider myTrigger) {
		myTrigger.gameObject.GetComponent<DragNDrop> ().IsMouseTriger = true;
		GameObject triggerObj = myTrigger.gameObject;

		if (triggerObj.name == "Souls" || triggerObj.name == "Souls(Clone)") {
			Rigidbody rigidbody = myTrigger.gameObject.GetComponent<Rigidbody>();
			GameObject obj = GameObject.Find("Main Camera");

			if (name == "Hell") {
				rigidbody.AddForce(new Vector3(0, -500f, 0));
				obj.GetComponent<StatisticScript>().addSoulToHell(triggerObj);
			}

			if (name == "Heaven") {
				rigidbody.AddForce(new Vector3(0, 500f, 0));
				obj.GetComponent<StatisticScript>().addSoulToHeaven(triggerObj);
			}

			Destroy(myTrigger.gameObject, 5.0f);
		}
	}
}

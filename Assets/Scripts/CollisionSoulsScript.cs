using UnityEngine;
using System.Collections;

public class CollisionSoulsScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider myTrigger) {
		GameObject triggerObj = myTrigger.gameObject;
		if (triggerObj.name == "Souls" || triggerObj.name == "Souls(Clone)") {
			Physics.IgnoreCollision(myTrigger, GetComponent<Collider>());
		}
	}
}

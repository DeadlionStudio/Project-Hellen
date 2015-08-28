﻿using UnityEngine;
using System.Collections;

public class DeletingScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider myTrigger) {
		if (myTrigger.gameObject.name == "Souls" || myTrigger.gameObject.name == "Souls(Clone)") {
			Rigidbody rigidbody = myTrigger.gameObject.GetComponent<Rigidbody>();
			if (name == "Hell") {
				rigidbody.AddForce(new Vector3(0, -500f, 0));
			}
			if (name == "Heaven") {
				rigidbody.AddForce(new Vector3(0, 500f, 0));
			}
			Destroy(myTrigger.gameObject, 5.0f);
		}
	}
}

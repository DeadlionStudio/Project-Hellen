using UnityEngine;
using System.Collections;

public class DeletingScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider myTrigger) 
	{
		if (myTrigger.gameObject.name == "Souls" || myTrigger.gameObject.name == "Souls(Clone)")
		{
			Destroy(myTrigger.gameObject, 0.1f);
		}
	}
}

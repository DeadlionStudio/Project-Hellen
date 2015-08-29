using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject thePrefab;
	public int maxRandomDigit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		System.Random rnd = new System.Random();
		int randomChance = rnd.Next(maxRandomDigit);

		if (randomChance == 0) {
			GameObject instance =  Instantiate(thePrefab, 
			                       thePrefab.transform.position, 
			                       thePrefab.transform.rotation) as GameObject; 
		}
	}
}

using UnityEngine;
using System.Collections;

public class MainSoulScript : MonoBehaviour {
	private bool isGood;
	private string firstHint;
	private string secondHint;
	private string thirdHint;

	public bool canShowSecondHint = false;
	public bool canShowThirdHint = false;

	public bool isForHeaven
	{
		get { return this.isGood; }
	}
	public string firstInfo
	{
		get { return this.firstHint; }
	}
	public string secondInfo
	{
		get { 
			if (this.canShowSecondHint) {
				return this.secondHint;
			} else {
				return "Buy second hint about souls";
			}
		}
	}
	public string thirdInfo
	{
		get { 
			if (this.canShowThirdHint) {
				return this.thirdHint;
			} else {
				return "Buy third hint about souls";
			}
		}
	}

	// Use this for initialization
	void Start () {
		System.Random rnd = new System.Random();
		int randomInt = rnd.Next (2);
		if (randomInt == 0) {
			this.isGood = true;
			this.firstHint = "Maybe good man";
			this.secondHint = "Looks like good man";
			this.thirdHint = "Really good man";
		} else {
			this.isGood = false;
			this.firstHint = "Maybe bad man";
			this.secondHint = "Looks like bad man";
			this.thirdHint = "Really bad man";
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

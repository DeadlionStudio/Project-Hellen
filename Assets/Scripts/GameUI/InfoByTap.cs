using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InfoByTap : MonoBehaviour {

	private static bool isHellChoosen = false;
	private static bool isHeavenChoosen = false;
	private static bool isEartheChoosen = false;
	private Text displayName;
	private Text firstInfoText;
	private Text secondInfoText;
	private Text thirdInfoText;
	private StatisticScript cameraScript;
	// Use this for initialization
	void Start () {
		GameObject nameField = GameObject.Find ("Name Field");
		GameObject firstInfo = GameObject.Find ("FirstInfo");
		GameObject secondInfo = GameObject.Find ("SecondInfo");
		GameObject thirdInfo = GameObject.Find ("ThirdInfo");
		GameObject camera = GameObject.Find ("Main Camera");
		this.displayName = nameField.GetComponent<Text>();
		this.firstInfoText = firstInfo.GetComponent<Text>();
		this.secondInfoText = secondInfo.GetComponent<Text>();
		this.thirdInfoText = thirdInfo.GetComponent<Text>();
		this.cameraScript = camera.GetComponent<StatisticScript>();
	}

	void OnMouseDown(){
		InfoByTap.isHellChoosen = false;
		InfoByTap.isHeavenChoosen = false;
		InfoByTap.isEartheChoosen = false;
		string tappedObjectName = gameObject.name;
		if (tappedObjectName == "BackGround") {
			setDisplayInformation("\tEarth", "\tYour rating on Earth: " + this.cameraScript.ratingOnEarth, string.Empty, string.Empty);
			InfoByTap.isEartheChoosen = true;
		} else if (tappedObjectName == "Heaven") {
			setDisplayInformation("\tHeaven", "\tPercent of good people in Heaven: " + (this.cameraScript.heaven.percentOfGoodSouls * 100), "\tPercent of bad people in Heaven: " + (this.cameraScript.heaven.percentOfBadSouls * 100), string.Empty);
			InfoByTap.isHeavenChoosen = true;
		} else if (tappedObjectName == "Hell") {
			setDisplayInformation("\tHell", "\tPercent of good people in Hell: " + (this.cameraScript.hell.percentOfGoodSouls * 100), "\tPercent of bad people in Hell: " + (this.cameraScript.hell.percentOfBadSouls * 100), string.Empty);
			InfoByTap.isHellChoosen = true;
		} else if (tappedObjectName == "Souls" || tappedObjectName == "Souls(Clone)") {
			MainSoulScript soulsScript = gameObject.GetComponent<MainSoulScript>();
			setDisplayInformation(soulsScript.Name, soulsScript.firstInfo, soulsScript.secondInfo, soulsScript.thirdInfo);
		}
		
	}


	void setDisplayInformation(string forName, string forFirstInfo, string forSecondInfo, string forThirdInfo)
	{
		this.displayName.text = forName;
		this.firstInfoText.text = forFirstInfo;
		this.secondInfoText.text = forSecondInfo;
		this.thirdInfoText.text = forThirdInfo;
	}
	
	// Update is called once per frame
	void Update () {
		if (InfoByTap.isEartheChoosen) {
			setDisplayInformation("\tEarth", "\tYour rating on Earth: " + this.cameraScript.ratingOnEarth, string.Empty, string.Empty);
		} else if (InfoByTap.isHeavenChoosen) {
			setDisplayInformation("\tHeaven", "\tPercent of good people in Heaven: " + (this.cameraScript.heaven.percentOfGoodSouls * 100), "\tPercent of bad people in Heaven: " + (this.cameraScript.heaven.percentOfBadSouls * 100), string.Empty);
		} else if (InfoByTap.isHellChoosen) {
			setDisplayInformation("\tHell", "\tPercent of good people in Hell: " + (this.cameraScript.hell.percentOfGoodSouls * 100), "\tPercent of bad people in Hell: " + (this.cameraScript.hell.percentOfBadSouls * 100), string.Empty);
		}
	}
}

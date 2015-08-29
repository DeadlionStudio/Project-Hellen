using UnityEngine;
using System.Collections;

public class StatisticObject
{
	private int numberOfGoodSouls;
	private int numberOfBadSouls ;

	public StatisticObject(int numberOfGood, int numberOfBad)
	{
		this.numberOfBadSouls = numberOfBad;
		this.numberOfGoodSouls = numberOfGood;
	}
	public StatisticObject()
	{
		this.numberOfBadSouls = 0;
		this.numberOfGoodSouls = 0;
	}

	public double percentOfGoodSouls{
		get{
			return (double)this.numberOfGoodSouls / (double)(this.numberOfGoodSouls + this.numberOfBadSouls);
		}
	}

	public double percentOfBadSouls{
		get{
			return (double)this.numberOfBadSouls / (double)(this.numberOfGoodSouls + this.numberOfBadSouls);
		}
	}

	public void addSoul (GameObject soul)
	{
		if (soul.GetComponent<MainSoulScript> ().isForHeaven) {
			this.numberOfGoodSouls++;
		} else {
			this.numberOfBadSouls++;
		}
	}
}

public class StatisticScript : MonoBehaviour {

	private const double rateRatio = 0.95;
	private const double ratingRatio = 0.0001;

	private double ratingOnEarth = 1;

	private StatisticObject heaven;
	private StatisticObject hell;
	// Use this for initialization
	void Start () {
		this.heaven = new StatisticObject (1, 0);
		this.hell = new StatisticObject (0, 1);
	}


	public void addSoulToHell(GameObject soul)
	{
		this.hell.addSoul(soul);
	}
	public void addSoulToHeaven(GameObject soul)
	{
		this.heaven.addSoul(soul);
	}
	
	// Update is called once per frame
	void Update () {
		double percentOfBadInHell = this.hell.percentOfBadSouls;
		double percentOfGoodInHell = this.hell.percentOfGoodSouls;
		double percentOfGoodInHeaven = this.heaven.percentOfGoodSouls;
		double percentOfBadInHeaven = this.heaven.percentOfBadSouls;

		if (percentOfBadInHell > rateRatio && percentOfGoodInHeaven > rateRatio) {
			double coeff = System.Math.Min (percentOfBadInHell - rateRatio, percentOfGoodInHeaven - rateRatio);
			this.ratingOnEarth += coeff * Time.deltaTime * rateRatio;
		} else {
			double coeff = System.Math.Max (rateRatio - percentOfBadInHeaven, rateRatio - percentOfGoodInHell);
			this.ratingOnEarth -= coeff * Time.deltaTime * rateRatio;

			if(this.ratingOnEarth < 0){
				Debug.Log("GAME OVER");
			}
		}
		Debug.Log("GoodInHeaven " + this.heaven.percentOfGoodSouls);
		Debug.Log("BadInHeaven " + this.heaven.percentOfBadSouls);
	}
}

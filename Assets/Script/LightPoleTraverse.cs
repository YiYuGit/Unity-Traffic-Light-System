using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script control the traffic light for another direction
/// The light times should be set in pair
/// </summary>
public class LightPoleTraverse : MonoBehaviour {

	private bool alive = true;

	[Header("Drop the light obejcts here")]
	public GameObject redLight;
	public GameObject yellowLight;
	public GameObject greenLight;

	[Header("Set the time for lights")]

	public int redTime = 12;
	public int yellowTime = 2;
	public int greenTime = 10;

	void Start () {

		redLight.SetActive(false);
		yellowLight.SetActive(false);
		greenLight.SetActive(false);

		StartCoroutine ("Lightsequence");

	}



	IEnumerator Lightsequence()
	{
		while (alive)
		{

			greenLight.SetActive(true);
			yield return new WaitForSeconds (greenTime);
			greenLight.SetActive(false);

			yellowLight.SetActive(true);
			yield return new WaitForSeconds (yellowTime);
			yellowLight.SetActive(false);

			redLight.SetActive(true);
			yield return new WaitForSeconds (redTime);
			redLight.SetActive(false);

		}

	}

}

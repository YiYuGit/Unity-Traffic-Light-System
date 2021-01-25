using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script control the traffic light for one direction
/// In the prefab,under the red and green light object, there are box collider with 'red' and 'green' tags, they can be used
/// as the trigger obejct for car to stop and go
/// </summary>
public class LightPole : MonoBehaviour {

	private bool alive = true;

	[Header("Drop the light obejcts here")]
	public GameObject redLight;
	public GameObject yellowLight;
	public GameObject greenLight;

	[Header("Set the time for lights")]
	public int redTime = 13;
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
			
			redLight.SetActive(true);
			yield return new WaitForSeconds (redTime);
			redLight.SetActive(false);


			greenLight.SetActive(true);
			yield return new WaitForSeconds (greenTime);
			greenLight.SetActive(false);


			yellowLight.SetActive(true);
			yield return new WaitForSeconds (yellowTime);
			yellowLight.SetActive(false);
		}

		}

}

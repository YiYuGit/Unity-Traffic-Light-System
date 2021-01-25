using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script control the traffic light for one direction and control the pedestrian signal
/// Additional sounds can be put as the children of light or pedestrian signal
/// </summary>
public class LightPoleWithPedSignal : MonoBehaviour
{

    private bool alive = true;

    [Header("Drop the light obejcts here")]
    public GameObject redLight;
    public GameObject yellowLight;
    public GameObject greenLight;

    [Header("Drop the walk signal obejects here")]
    public GameObject walk1;
    public GameObject walk2;
    public GameObject dontwalk1;
    public GameObject dontwalk2;

    [Header("Set the time for lights")]
    public int redTime = 13;
    public int yellowTime = 2;
    public int greenTime = 10;




    void Start()
    {

        redLight.SetActive(false);
        yellowLight.SetActive(false);
        greenLight.SetActive(false);

        StartCoroutine("Lightsequence");

    }


    IEnumerator Lightsequence()
    {
        while (alive)
        {

            redLight.SetActive(true);
            dontwalk1.SetActive(true);
            dontwalk2.SetActive(true);
            yield return new WaitForSeconds(redTime);
            redLight.SetActive(false);
            dontwalk1.SetActive(false);
            dontwalk2.SetActive(false);



            greenLight.SetActive(true);
            walk1.SetActive(true);
            walk2.SetActive(true);
            yield return new WaitForSeconds(greenTime);
            greenLight.SetActive(false);
            walk1.SetActive(false);
            walk2.SetActive(false);


            yellowLight.SetActive(true);
            dontwalk1.SetActive(true);
            dontwalk2.SetActive(true);
            yield return new WaitForSeconds(yellowTime);
            yellowLight.SetActive(false);
            dontwalk1.SetActive(false);
            dontwalk2.SetActive(false);
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartSystem : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Combat.getTrumpHealth() == 4)
        {
            GameObject.Find("Red Heart 5").SetActive(false);
        }
        else if (Combat.getTrumpHealth() == 3)
        {
            GameObject.Find("Red Heart 4").SetActive(false);
        }
        else if (Combat.getTrumpHealth() == 2)
        {
            GameObject.Find("Red Heart 3").SetActive(false);
        }
        else if (Combat.getTrumpHealth() == 1)
        {
            GameObject.Find("Red Heart 2").SetActive(false);
        }
        else if (Combat.getTrumpHealth() == 0)
        {
            GameObject.Find("Red Heart 1").SetActive(false);
        }
    }
}

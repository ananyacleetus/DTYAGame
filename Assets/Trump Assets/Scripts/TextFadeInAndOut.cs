using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFadeInAndOut : MonoBehaviour {

    GameObject start;

	// Use this for initialization
	void Start () {
        start = GameObject.Find("Start");
        start.GetComponent<Text>().CrossFadeAlpha(25, 3, false);
    }
	
	// Update is called once per frame
	void Update () {
        if (start.GetComponent<Text>().color.a == 25)
        {
            start.GetComponent<Text>().CrossFadeAlpha(255, 3, false);
        }
        else if (start.GetComponent<Text>().color.a == 255)
        {
            start.GetComponent<Text>().CrossFadeAlpha(25, 3, false);
        }
    }
}

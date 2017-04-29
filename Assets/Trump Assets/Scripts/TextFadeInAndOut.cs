using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFadeInAndOut : MonoBehaviour {


	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("Start").GetComponent<Text>().color.a == 10)
        {
            GameObject.Find("Start").GetComponent<Text>().CrossFadeAlpha(255, 1, false);
        }
        else if (GameObject.Find("Start").GetComponent<Text>().color.a == 255)
        {
            GameObject.Find("Start").GetComponent<Text>().CrossFadeAlpha(10, 1, false);
        }
    }
}

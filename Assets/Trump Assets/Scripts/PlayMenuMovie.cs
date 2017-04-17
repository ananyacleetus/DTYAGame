using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayMenuMovie : MonoBehaviour {

    MovieTexture m;

	// Use this for initialization
	void Start () {
        m = (MovieTexture)GetComponent<RawImage>().texture;
        m.Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

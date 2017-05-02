using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour {

    Animator anim;
    GameObject cruz;

	// Use this for initialization
	void Start () {
        cruz = GameObject.Find("Cruz");
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (cruz.GetComponent<Player>().getVelocityX() < 0)
        {
            cruz.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            cruz.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDust : MonoBehaviour {

    float offsetX = 4f;
    float offsetY = 8f;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		if (WallAttack.getIsMoving())
        {
            GameObject.Find("DustStorm").GetComponent<ParticleSystem>().Play();
            Debug.Log("Dust is active!");
            GameObject.Find("DustStorm").transform.position = new Vector2(WallAttack.getWallPosX() + offsetX, WallAttack.getWallPosY() + offsetY);
        }
	}
}

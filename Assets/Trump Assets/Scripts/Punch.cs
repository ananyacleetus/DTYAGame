using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour {

    private static bool enemyIsHit = false;
    private static int hitCount = 0;
    private static int missCount = 0;

    public static bool getEnemyIsHit()
    {
        return enemyIsHit;
    }
    public static void setEnemyIsHit(bool val)
    {
        enemyIsHit = val;
    }
     
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            setEnemyIsHit(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            setEnemyIsHit(false);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q) && getEnemyIsHit() == true)
        {
            hitCount++;
            Debug.Log(hitCount + " punches landed!");
        }
        else if (Input.GetKeyDown(KeyCode.Q) && getEnemyIsHit() == false)
        {
            missCount++;
            Debug.Log(missCount + " punches missed!");
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour {

    private static bool enemyIsHit = false;
    private static int hitCount = 0;
    private static int missCount = 0;
    GameObject tile0;
    Rigidbody2D theRigidBody;

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
        tile0 = GameObject.Find("tile0");
        theRigidBody = tile0.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q) && getEnemyIsHit() == true)
        {
            hitCount++;
            theRigidBody.AddForce(Vector3.right * 10 * Time.deltaTime);
            Debug.Log(hitCount + " punches landed!");
        }
        else if (Input.GetKeyDown(KeyCode.Q) && getEnemyIsHit() == false)
        {
            missCount++;
            Debug.Log(missCount + " punches missed!");
        }
	}
}

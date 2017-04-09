using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour {

    public int trumpHealth = 5;
    public int trumpStamina = 5;
    private static bool trumpIsDead = false;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            trumpHealth--;
            Debug.Log("Health: " + trumpHealth);
        }
    }

    public static void setTrumpIsDead(bool val)
    {
        trumpIsDead = val;
    }

    public static bool getTrumpIsDead()
    {
        return trumpIsDead;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (trumpHealth <= 0)
        {
            setTrumpIsDead(true);
            Debug.Log("Donald is dead.");
        }
	}
}

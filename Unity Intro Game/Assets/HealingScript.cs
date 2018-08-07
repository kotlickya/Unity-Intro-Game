using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingScript : MonoBehaviour {

    float healingPoints = 0.1f; 
	// Use this for initialization
	void Start () {
		
	}
    private void OnCollisionStay(Collision collision)
    {
        HealthBar.instance.HealDamage(healingPoints);

    }
}

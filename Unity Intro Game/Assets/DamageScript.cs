using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour {

    //public bool isDamaging;
    public float damage = 1;
     
    private void OnCollisionStay(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            HealthBar.instance.TakeDamage(damage / 10);
            Debug.Log("Damage Collider Collide with player");
        }
    }
    
    
}

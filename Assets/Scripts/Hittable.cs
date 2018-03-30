using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hittable : MonoBehaviour {

    public float hitPoints;

    private void OnTriggerEnter(Collider other)
    {
        var damager = other.GetComponent<Damager>();
        if (damager != null) {
            hitPoints -= damager.damage;
            if (hitPoints < 0) {
                Destroy(gameObject);
            }
        }
    }
}

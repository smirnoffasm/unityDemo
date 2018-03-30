using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSpreader : MonoBehaviour {
    public float dispersion;
	// Use this for initialization
	void Start () {
        gameObject.transform.Rotate(Random.Range(-dispersion, dispersion), Random.Range(-dispersion, dispersion), Random.Range(-dispersion, dispersion));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

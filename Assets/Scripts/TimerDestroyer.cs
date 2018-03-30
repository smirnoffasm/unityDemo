using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDestroyer : MonoBehaviour {

    public float destroyIn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        destroyIn -= Time.deltaTime;
        if (destroyIn < 0)
        {
            Destroy(gameObject);
        }
	}
}

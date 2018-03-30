using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineguneDroneController : MonoBehaviour {
    public string explode_tag = "et";
    public float explode_speed = 5;

    private List<Transform> explodingShells;
	// Use this for initialization
	void Start () {
        ExplodeShell();
	}
	
	// Update is called once per frame
	void Update () {
        foreach (Transform child in explodingShells)
        {
            child.Translate(new Vector3(explode_speed * Time.deltaTime, explode_speed * 2 * Time.deltaTime, explode_speed * Time.deltaTime));
        }

    }

    void ExplodeShell()
    {
        explodingShells = new List<Transform>();
        foreach (Transform child in transform)
        {
            if(child.tag == explode_tag)
            {
                explodingShells.Add(child);
            }
        }
    }
}

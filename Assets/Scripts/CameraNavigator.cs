using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraNavigator : MonoBehaviour {

    public List<GameObject> waypointList = new List<GameObject>();
    public float speed = 2;

    private int nextWaypont = -1;
    private bool inMotion = true;

	// Use this for initialization
	void Start () {
        nextWaypont = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (!inMotion) return;
        setNextWaypoint();
        transform.Translate(0, 0, speed * Time.deltaTime);
	}

    void setNextWaypoint()
    {
        if (waypointList.Count <= nextWaypont)
        {
            inMotion = false;
            return;
        }
        transform.LookAt(waypointList[nextWaypont].transform);
        if (Vector3.Distance(transform.position, waypointList[nextWaypont].transform.position) > .5f)
        {
            return;
        }
        if (waypointList.Count <= nextWaypont + 1)
        {
            inMotion = false;
            return;
        }
        nextWaypont++;
        transform.LookAt(waypointList[nextWaypont].transform);
    }

}

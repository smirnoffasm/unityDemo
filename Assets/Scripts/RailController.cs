using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailController : MonoBehaviour {

    public GameObject vagon;
    public float maxLeft;
    public float maxRight;
    public float indentSpeed;

    private float curIndention = 0;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (!(Input.GetKey("d") && Input.GetKey("a")))
            if (Input.GetKey("d"))
            {
                var indention = indentSpeed * Time.deltaTime;
                if (curIndention + indention <= maxRight)
                {
                    curIndention += indention;
                    vagon.transform.Translate(indention, 0, 0);
                }
            } else if (Input.GetKey("a"))
            {
                var indention = indentSpeed * Time.deltaTime;
                if (curIndention - indention >= -maxLeft)
                {
                    curIndention -= indention;
                    vagon.transform.Translate(-indention, 0, 0);
                }
            }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wraparound : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if( transform.position.y > 42.6)
        {
            transform.Translate(0,-100f, 0, Space.World);
        }


        if (transform.position.y < -52.2)
        {
            transform.Translate(0, 100f, 0, Space.World);
        }

        if (transform.position.x < -30)
        {
            transform.Translate(142.2195f, 0, 0, Space.World);
        }

        if (transform.position.x > 120)
        {
            transform.Translate(-142.2195f, 0, 0, Space.World);
        }
    }
}

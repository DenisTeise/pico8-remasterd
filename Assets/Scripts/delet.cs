using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delet : MonoBehaviour {

    float time=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += 1;

		if(time >= 100)
        {
            Destroy(gameObject);
        }
	}
}

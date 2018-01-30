using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 8.0f;
        var y = Input.GetAxis("Vertical") * Time.deltaTime * 8.0f;
        var rotationz = transform.rotation.z;

        Debug.LogFormat("{0}", x);

        transform.Translate(x, y, 0);
        
        if(x > 0 && rotationz == -45f)
        {
            transform.Rotate(0, 0, -3f);
        }
/*
        if (x < 0 && rotationz < 45f)
        {
            transform.Rotate(0, 0, 45f);
        }
        */
    }
}

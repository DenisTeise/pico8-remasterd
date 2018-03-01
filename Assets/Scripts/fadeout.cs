using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeout : MonoBehaviour {
    public GameObject rausch;
    float x = 0.9f;

    float time = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        time += 0.1f;

        if (time >= 10)
        {
            x -= 0.005f;
        }

        Color c = rausch.GetComponent<SpriteRenderer>().color;
        c.a = x;
        rausch.GetComponent<SpriteRenderer>().color = c;
        Debug.LogFormat("{0}",time);
    }
}

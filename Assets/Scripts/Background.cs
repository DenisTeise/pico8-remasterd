using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    public GameObject Back;

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Back")
        {

            Debug.LogFormat("1");
        }

    }

    // Update is called once per frame
    void Update () {

    }
}

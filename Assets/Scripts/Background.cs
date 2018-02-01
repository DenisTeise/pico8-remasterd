using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    public GameObject Back;

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerExit(Collider collision)
    {
        if (collision.tag == "Back")
        {

            Debug.LogFormat("1");
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Back")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}

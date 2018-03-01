using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    public GameObject Back;

    private float x = 10.02f;
    private float y = 17.78f;

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Back")
        {
            for (int i = 0; i < 1; i++)
            {

                Instantiate(Back, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
            }
            Debug.LogFormat("1");

            x += 10.02f;
            y += 17.78f;
        }

    }

    // Update is called once per frame
    void Update () {

    }
}

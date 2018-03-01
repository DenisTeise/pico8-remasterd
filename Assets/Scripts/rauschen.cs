using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rauschen : MonoBehaviour {

    public GameObject rausch;
    public GameObject rausch1;

    float t = 0;
    float x = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (t==0 && x > 0)
        {
            x -= 0.01f;
        }

        if (t == 1)
        {
            x += 0.001f;

        }
            Color c = rausch.GetComponent<SpriteRenderer>().color;
            c.a = x;
            rausch.GetComponent<SpriteRenderer>().color = c;

            Color b = rausch1.GetComponent<SpriteRenderer>().color;
            b.a = x;
            rausch1.GetComponent<SpriteRenderer>().color = b;
	}

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {

            t = 1;
        }
        if (collision.tag == "enemy")
        {

            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {

            t = 0;
        }
    }
}

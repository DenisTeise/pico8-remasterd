using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public GameObject target;
    public GameObject explosion;
	public float moveSpeed;
    public float rotationSpeed;
    private float duration;
    private Vector3 direction;
    private Vector3 overshoot;
    private Vector3 overshoot2;

    public GameObject circ;
    public GameObject rad;

    void Start () {

        overshoot = transform.position;

    }


	void Update () {

       duration += 1f;


        circ = GameObject.Find("circ_0");
        rad = GameObject.Find("first");

        GetComponent<Enemy>().target = GameObject.Find("idle_orb_green");

        if (duration < 100)
        {
            overshoot2 = transform.position;

            direction = target.transform.position;

            transform.position = Vector3.MoveTowards(transform.position,direction, moveSpeed * (Random.Range(0.01f, 0.001f)));

        }

        
        if (duration > 100)
        {

            transform.Translate((overshoot - overshoot2)/-100);

        }


	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Shot")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
        }

        if (collision.tag == "goal")
        {
            Destroy(gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);

            if (circ.transform.localScale.y > 0)
            {

                 circ.transform.localScale -= new Vector3(1,1,0);
                 rad.transform.localScale -= new Vector3(0,0.035f,0);

            }
        }
    }
}
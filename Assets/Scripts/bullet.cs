using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

    public Rigidbody2D Bullet;

    public Transform player;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody2D clone;
            clone = Instantiate(Bullet, new Vector3(10,10,0),Quaternion.identity) as Rigidbody2D;
            clone.velocity = transform.TransformDirection(Vector3.forward * 10);

        }

        transform.Translate(0, 0.1f, 0);
        //player.transform.position, player.transform.rotation
    }
}

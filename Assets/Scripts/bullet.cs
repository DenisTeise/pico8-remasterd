using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

    public Rigidbody2D BulletsSpriteSheetBlue_0;

    public Transform player;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody2D clone;
            clone = Instantiate(BulletsSpriteSheetBlue_0, player.transform.position, player.transform.rotation) as Rigidbody2D;
            clone.velocity = transform.TransformDirection(Vector3.forward * 10);
        }

        transform.Translate(0, 0.1f, 0);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private float x = 0.001f;

    public GameObject player;

    public GameObject BulletsSpriteSheetBlue_0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        player.transform.position = transform.position;

        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj = Instantiate(BulletsSpriteSheetBlue_0, transform.position, transform.rotation);

        }

        var z = Input.GetAxis("Horizontal") * Time.deltaTime * 75.0f;
        var y = Input.GetAxis("Vertical") * Time.deltaTime * 5;

        if (Input.GetKey(KeyCode.UpArrow) && x < 0.1)
        {

            x = 1.1f * x;

        }

        if (Input.GetKey(KeyCode.DownArrow) && x > 0.001)
        {

            x = x / 1.1f;

        }
           // Debug.LogFormat("{0}", x);

        transform.Translate(0, x, 0);
        transform.Rotate(0, 0, -z*2);

    }
}

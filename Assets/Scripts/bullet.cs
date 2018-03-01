using System.Collections.Generic;
using UnityEngine;
using System.Collections;


public class bullet : MonoBehaviour {

    private float duration;

	// Update is called once per frame
	void Update () {

        transform.Translate(0, 0.2f, 0);

        duration += 1;

        if (duration > 100)
        {
            Destroy(gameObject);
        }

    }
}


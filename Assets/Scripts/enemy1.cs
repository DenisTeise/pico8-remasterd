using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour {

    public GameObject asteroidPrefab;
    Vector2 myVector3;
    int counter = 100;

    // Use this for initialization
    void Start () {

        for (int i = 0; i < counter; i++)
        {

            myVector3 = Random.insideUnitCircle * 3 + new Vector2(transform.position.x, transform.position.y);
            GameObject go = Instantiate(asteroidPrefab, myVector3, Quaternion.identity) as GameObject;
            go.transform.parent = transform;

           // Instantiate(asteroidPrefab, myVector3, Quaternion.identity);
        }

	}
	
	// Update is called once per frame
	void Update () {

    }
}

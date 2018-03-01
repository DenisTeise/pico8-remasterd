using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astro : MonoBehaviour {

    public GameObject asteroidPrefab;
    GameObject mySpaceship;
    Vector2 myVector3;
    public int range;
    public int counter;

    float time = 80;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        time += 0.1F;

        if (time>=100)
        {
            time = 0;
            spawnEnemies();
        }
    }

    void spawnEnemies()
    {
        mySpaceship = GameObject.Find("idle_orb_green");
        if (mySpaceship != null)
        {
            for (int i = 0; i < counter; i++)
            {
                myVector3 = Random.insideUnitCircle * (Random.Range(50, 100.0f) )+ new Vector2(transform.position.x, transform.position.y);
                Instantiate(asteroidPrefab, myVector3, Quaternion.identity);
            }
        }
    }
}

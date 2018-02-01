using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astro : MonoBehaviour {

    public GameObject asteroidPrefab;
    GameObject mySpaceship;
    Vector3 myVector3;
    public int range;
    public int counter;

	// Use this for initialization
	void Start () {
        counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            spawnEnemies();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Shot")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }

    void spawnEnemies()
    {
        mySpaceship = GameObject.Find("idle_player_basic");
        if (mySpaceship != null)
        {
            for (int i = 0; i < counter; i++)
            {
                myVector3 = Random.insideUnitCircle * range;
                Instantiate(asteroidPrefab, myVector3, Quaternion.identity);
            }
        }
    }
}

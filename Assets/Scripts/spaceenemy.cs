using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceenemy : MonoBehaviour {

    public GameObject target;
    public float moveSpeed;
    public float rotationSpeed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<spaceenemy>().target = GameObject.Find("idle_player_basic");

        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime);
    }
}

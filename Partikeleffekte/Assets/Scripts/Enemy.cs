using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    GameObject player;
    float speed;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        speed = 1.5f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position + new Vector3(0, 1.5f, 0), speed * Time.deltaTime);
	}

  
}

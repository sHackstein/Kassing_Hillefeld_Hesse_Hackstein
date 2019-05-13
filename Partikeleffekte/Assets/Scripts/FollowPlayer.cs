using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {


    public float speed = 1;

    GameObject player;


	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        moveToTarget();
    }

    void moveToTarget()
    {
        Vector3 vecDistance = player.transform.position + new Vector3(0, 2, 0) - transform.position;
        float distance = Vector3.Distance(transform.position, player.transform.position + new Vector3(0, 2, 0));

        transform.position += vecDistance / distance * speed * Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

    List<ParticleCollisionEvent> collisionEvents;

    // Use this for initialization
    void Start () {
        collisionEvents = new List<ParticleCollisionEvent>();
    }


    void OnParticleCollision(GameObject other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Test Player");
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}

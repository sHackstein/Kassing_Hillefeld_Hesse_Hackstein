using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Partikel_System : MonoBehaviour {

    public ParticleSystem partikelParent;
    public Light light;
    public int delay;

	// Use this for initialization
	void Start () {

        if (delay == 0)
        {
            light.enabled = true;
            partikelParent.Play();
            Debug.Log(delay);
        }
        else
        {
            light.enabled = false;
            partikelParent.Stop();
            Debug.Log("hi1" + delay);
        }

    }
	
	// Update is called once per frame
	void Update () {

        if(delay == 0)
        {
            light.enabled = true;
            partikelParent.Play();
            Debug.Log(delay);
        }
        else
        {
            delay--;
            light.enabled = false;
            partikelParent.Stop();
            Debug.Log("Hi" + delay);
        }

        
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListicBehavior : MonoBehaviour {

    // Use this for initialization
    public float brzina = 1;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position - new Vector3(brzina * Time.deltaTime, 0,0);
	}

    void onCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Stickman")
        {
            Destroy(gameObject);
            //provjeriti da li je zlatni listic ili obicni i povecati score ovdje
        }
    }
}

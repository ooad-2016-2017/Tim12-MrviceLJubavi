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
        if (collision.collider.gameObject.tag == "AE" || collision.collider.gameObject.tag == "EE" || collision.collider.gameObject.tag == "TK" || collision.collider.gameObject.tag == "RI")
        {
            Destroy(gameObject);
            //provjeriti da li je zlatni listic ili obicni i povecati score ovdje
            //nisam uspjela skontati kako trebaš provjeriti koje je vrste listić, pa kad to središ samo ubaci provjeru:
            
            if (true)
            {
                JumpingScript.Observer.Update1(JumpingScript.S);
            }
            else JumpingScript.Observer.Update5(JumpingScript.S);
        }
    }
}

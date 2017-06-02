using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListicBehavior : MonoBehaviour {

    // Use this for initialization
    public static float brzina = 1;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position - new Vector3(brzina * Time.deltaTime, 0,0);
	}

}

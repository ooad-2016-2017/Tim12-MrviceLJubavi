using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListicBehavior : MonoBehaviour {

    // Use this for initialization
    private static float brzina = 1;

    public static float Brzina
    {
        get
        {
            return brzina;
        }

        set
        {
            brzina = value;
        }
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position - new Vector3(Brzina * Time.deltaTime, 0,0);
	}

}

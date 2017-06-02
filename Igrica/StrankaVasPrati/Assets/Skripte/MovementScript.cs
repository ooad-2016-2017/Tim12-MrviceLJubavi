using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

    // Use this for initialization
    static float brzina=(float)1.01;

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
        HandleMovement();
	}

    void HandleMovement()
    {
        transform.position = transform.position - new Vector3(Brzina * Time.deltaTime, 0, 0);
    }
}

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

    //[SerializeField]
    //private float brzina;

    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        HandleMovement();
	}

    void HandleMovement()
    {
        //stickman.velocity = new Vector2(1*povecaj, 0);
        //povecaj = stickman.velocity.x;
        transform.position = transform.position - new Vector3(Brzina * Time.deltaTime, 0, 0);
    }
}

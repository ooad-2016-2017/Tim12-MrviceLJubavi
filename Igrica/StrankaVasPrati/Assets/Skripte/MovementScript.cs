using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

    // Use this for initialization
    Rigidbody2D stickman;
    static float povecaj=(float)1.01;

    //[SerializeField]
    //private float brzina;

	void Start () {
        stickman = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        HandleMovement();
	}

    void HandleMovement()
    {
        stickman.velocity = new Vector2(1*povecaj, 0);
        povecaj = stickman.velocity.x;
    }
}

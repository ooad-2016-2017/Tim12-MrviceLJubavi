using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingScript : MonoBehaviour {



    public Rigidbody2D stickman;

	// Use this for initialization
	void Start () {
        //treba instancirati stickmana
        stickman = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0))
        {
            stickman.velocity = new Vector2(1,(float)4.5);
        }
	}

    //nedovrseno, treba stickman
    public bool stojiLi()
    {
        if (stickman.velocity.y<-4.1)
        {
            return true;
        }
        return false;
    }

}

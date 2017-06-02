using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpingScript : MonoBehaviour {
    IState stanjeStickmana=new StateNormal();
    static Stickman s=new Stickman();
    static IObserver observer=new Observer();
    public static Stickman S
    {
        get
        {
            return s;
        }

        set
        {
            s = value;
        }
    }

    public static IObserver Observer
    {
        get
        {
            return observer;
        }

        set
        {
            observer = value;
        }
    }

    // Use this for initialization
    void Start () {
        stanjeStickmana.Handle(s);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0))
        {
            stanjeStickmana = new StateJump();
            stanjeStickmana.Handle(s);
            GetComponent<Rigidbody2D>().velocity = new Vector2(1, s.Y);
        }
	}

    //nedovrseno, treba stickman
    public bool stojiLi()
    {
        return stanjeStickmana is StateNormal;
    }

}

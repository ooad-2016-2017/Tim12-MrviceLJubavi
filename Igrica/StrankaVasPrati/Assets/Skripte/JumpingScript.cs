using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpingScript : MonoBehaviour {
    IState stanjeStickmana=new StateNormal();
    static Stickman s=new Stickman();
    static IObserver observer=new Observer();

    [SerializeField]
    GameObject mete;

    [SerializeField]
    private Transform[] groundpoints;
    private bool stojiIliNe;
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
    private bool skok;
    private float jumpForce = 500;
	
	// Update is called once per frame
	void Update () {
        stojiIliNe = stojiLi();
        if (Input.GetMouseButton(0))
        {
            skok = true;
            stanjeStickmana = new StateJump();
            stanjeStickmana.Handle(s);
            GetComponent<Rigidbody2D>().velocity = new Vector2(1, s.Y);
        }
        GameObject meta = Instantiate(mete);
	}

    private void HandleMovement()
    {
        if (stojiIliNe && skok)
        {
            stojiIliNe = false;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
        }
    }

    public bool stojiLi()
    {
        var rigidbody = GetComponent<Rigidbody2D>();
        if (rigidbody.velocity.y<=-4.1)
        {
            foreach(Transform gp in groundpoints)
            {
                Collider2D[] colliders = Physics2D.OverlapCircleAll(gp.position, 0.2f);
                for (int i=0; i<colliders.Length; i++)
                {
                    if (colliders[i].gameObject!=gameObject)
                    {
                        return true;
                    }
                }
            }
            
        }
        return false;
        //return stanjeStickmana is StateNormal;
    }

}

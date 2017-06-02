using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnistiListic : MonoBehaviour {

    void onCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.GetComponent<JumpingScript>().tag.Equals("AE") || collision.collider.gameObject.GetComponent<JumpingScript>().tag.Equals("EE") || collision.collider.GetComponent<JumpingScript>().gameObject.tag.Equals("TK") || collision.collider.GetComponent<JumpingScript>().gameObject.tag.Equals( "RI"))
        {
            Destroy(gameObject);
            //provjeriti da li je zlatni listic ili obicni i povecati score ovdje
            //nisam uspjela skontati kako trebaš provjeriti koje je vrste listić, pa kad to središ samo ubaci provjeru:
            bool obicni = gameObject.GetComponent<Renderer>().material.GetColor("Gray") == Color.gray;
            if (obicni)
            {
                JumpingScript.Observer.Update1(JumpingScript.S);
            }
            else JumpingScript.Observer.Update5(JumpingScript.S);
        }
    }
}

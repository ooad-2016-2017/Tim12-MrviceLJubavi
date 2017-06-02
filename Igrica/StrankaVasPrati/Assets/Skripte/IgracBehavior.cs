using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgracBehavior : MonoBehaviour {

    public static float brzina = 1;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<JumpingScript>().tag.Equals("AE") && MainMenuScript.kojiIgrac != 1)
        {
            transform.position = transform.position - new Vector3(brzina * Time.deltaTime, 0, 0);
        }
        if (gameObject.GetComponent<JumpingScript>().tag.Equals("EE") && MainMenuScript.kojiIgrac != 2)
        {
            transform.position = transform.position - new Vector3(brzina * Time.deltaTime, 0, 0);
        }
        if (gameObject.GetComponent<JumpingScript>().tag.Equals("RI") && MainMenuScript.kojiIgrac != 3)
        {
            transform.position = transform.position - new Vector3(brzina * Time.deltaTime, 0, 0);
        }
        if (gameObject.GetComponent<JumpingScript>().tag.Equals("TK") && MainMenuScript.kojiIgrac != 4)
        {
            transform.position = transform.position - new Vector3(brzina * Time.deltaTime, 0, 0);
        }
    }
}

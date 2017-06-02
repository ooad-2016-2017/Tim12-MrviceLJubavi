using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

    public GameObject[] listic;
    public Vector3 vektor;
    int izbor;
    static float sekunde = 5;

    void Start () {
        vektor = new Vector3(0, 0,0);
        StartCoroutine(cekaj());
	}
	
	// Update is called once per frame
	void Update () {
    }

    Dictionary<String, GameObject> listici = new Dictionary<string, GameObject>();

    public static float Sekunde
    {
        get
        {
            return sekunde;
        }

        set
        {
            sekunde = value;
        }
    }

    IEnumerator cekaj()
    {
        yield return new WaitForSeconds(sekunde);
        while (true)
        {
            izbor = UnityEngine.Random.Range(0, 2);
            Vector3 pozicija = new Vector3(0, izbor,0);
            //factory.getLisic("zlatni");
            GameObject m;
            if (izbor == 0)
            {
                m = Instantiate(listic[0], pozicija + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            } else
            {
                if (listic != null)
                {
                    m = (GameObject)Instantiate(listic[1], pozicija + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
                }
            }
            yield return new WaitForSeconds(sekunde);
        }
    }
}

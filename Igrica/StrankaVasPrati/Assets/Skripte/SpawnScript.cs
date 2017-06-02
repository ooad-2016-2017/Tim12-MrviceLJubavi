using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

    //ListicFactory factory;
    public GameObject listic;
    public Vector3 vektor;
    int izbor;


    void Start () {
        //factory = new ListicFactory();
        vektor = new Vector3(0, 0,0);
        StartCoroutine(cekaj());
	}
	
	// Update is called once per frame
	void Update () {
    }

    /*
    class ListicFactory
    {

        Dictionary<String, GameObject> listici = new Dictionary<string, GameObject>();
        public void getLisic(String boja) {
            
            if (listici.ContainsKey(boja))
            {
                GameObject g = Instantiate(listici[boja]);
            } else
            {
                GameObject listic = Instantiate(listic, vektor);
                
                //listici.Add(boja, listic); //provjeri kako se tacno kreira instanca objekta sa nekom bojom, tj Material
                
            }
        }

        
    }*/

    Dictionary<String, GameObject> listici = new Dictionary<string, GameObject>();
    IEnumerator cekaj()
    {
        yield return new WaitForSeconds(1);
        while (true)
        {
            izbor = UnityEngine.Random.Range(0, 2);
            Vector3 pozicija = new Vector3(0, 1,0);
            //factory.getLisic("zlatni");
            GameObject m;
            if (izbor == 0)
            {
                m = Instantiate(listic, pozicija + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
                m.GetComponent<Renderer>().material.SetColor("Gray", Color.gray);
                //obicni
                /*
                if (listici.ContainsKey("obicni"))
                {
                    m = Instantiate(listici["obicni"]);
                }
                else
                {
                    m = Instantiate(listic, pozicija + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
                    m.GetComponent<Renderer>().material.SetColor("Gray", Color.gray);
                    listici.Add("obicni", m);
                }*/
            } else
            {
                m = (GameObject)Instantiate(listic, pozicija + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
                m.GetComponent<Renderer>().material.SetColor("Yellow", Color.yellow);
                //zlatni
                /*
                if (listici.ContainsKey("zlatni"))
                {
                    m = Instantiate(listici["zlatni"]);
                }
                else
                {
                    m = (GameObject)Instantiate(listic, pozicija + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
                    m.GetComponent<Renderer>().material.SetColor("Yellow", Color.yellow);
                    listici.Add("zlatni", m);
                }*/
            }
            yield return new WaitForSeconds(4);
        }
    }
}

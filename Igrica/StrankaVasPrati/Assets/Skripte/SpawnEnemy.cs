using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

    public GameObject[] stickman;
    public Vector3 vektor;
    int izbor;


    void Start()
    {
        vektor = new Vector3(0, 0, 0);
        StartCoroutine(cekaj());
    }


    Dictionary<String, GameObject> igraci = new Dictionary<string, GameObject>();
    IEnumerator cekaj()
    {
        int kojiIgrac = MainMenuScript.kojiIgrac;
        yield return new WaitForSeconds(1);
        while (true)
        {
            izbor = UnityEngine.Random.Range(1, 5);
            Vector3 pozicija = new Vector3(-1, -2, 0);
            GameObject m;
            
            if (izbor==1 && kojiIgrac!=1)
            {
                //AE
                if (!igraci.ContainsKey("AE"))
                {
                    m =(GameObject) Instantiate(stickman[0], pozicija + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
                    igraci.Add("AE", m);
                } else
                {
                    m = Instantiate(igraci["AE"]);
                }
            }
            else if (izbor == 2 && kojiIgrac != 2)
            {
                //EE
                if (!igraci.ContainsKey("EE"))
                {
                    m = (GameObject)Instantiate(stickman[1], pozicija + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
                    igraci.Add("EE", m);
                }
                else
                {
                    m = Instantiate(igraci["EE"]);
                }
            }
            else if (izbor == 3 && kojiIgrac != 3)
            {
                //RI
                if (!igraci.ContainsKey("RI"))
                {
                    m = (GameObject)Instantiate(stickman[2], pozicija + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
                    igraci.Add("RI", m);
                }
                else
                {
                    m = Instantiate(igraci["RI"]);
                }
            }
            else if (izbor == 4 && kojiIgrac != 4)
            {
                //TK
                if (!igraci.ContainsKey("TK"))
                {
                    m = (GameObject)Instantiate(stickman[3], pozicija + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
                    igraci.Add("TK", m);
                }
                else
                {
                    m = Instantiate(igraci["TK"]);
                }
            } else
            {
                continue;
            }

            yield return new WaitForSeconds(UnityEngine.Random.Range(1,6));
        }
    }

}

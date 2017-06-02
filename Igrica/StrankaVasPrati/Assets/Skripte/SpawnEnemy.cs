using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

    public GameObject[] stickman;
    public Vector3 vektor;
    int izbor;
    private float cooldown = -1f;
    private static float cooldownAmount = 10f;

    public static float CooldownAmount
    {
        get
        {
            return cooldownAmount;
        }

        set
        {
            cooldownAmount = value;
        }
    }

    void Start()
    {
        //vektor = new Vector3(0, 0, 0);
        //StartCoroutine(cekaj());
        foreach (GameObject g in stickman)
        {
            if (MainMenuScript.kojiIgrac == 1 && g.name == "AE1")
            {
                g.SetActive(false);
                break;
            }
            else if (MainMenuScript.kojiIgrac == 2 && g.name == "EE1")
            {
                g.SetActive(false);
                break;
            }
            else if (MainMenuScript.kojiIgrac == 3 && g.name == "RI1")
            {
                g.SetActive(false);
                break;
            }
            else if (MainMenuScript.kojiIgrac == 4 && g.name == "TK1")
            {
                g.SetActive(false);
                break;
            }
        }
    }

    private void Update()
    {
        if (cooldown<0)
        {
            createEnemy();
            cooldown = CooldownAmount;
        }
        cooldown -= Time.deltaTime;
    }
    public void createEnemy ()
    {
        Vector3 pozicija = new Vector3(10, UnityEngine.Random.Range(0, 2), 0);
        Instantiate(stickman[(int)UnityEngine.Random.Range(0, stickman.Length)], pozicija, transform.rotation);
    }
    /*Dictionary<String, GameObject> igraci = new Dictionary<string, GameObject>();
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


        }*/

}

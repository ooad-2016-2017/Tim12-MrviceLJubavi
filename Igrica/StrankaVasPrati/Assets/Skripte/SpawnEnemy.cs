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
        Vector3 pozicija;
        if (MovementScript.Brzina<5) pozicija= new Vector3(10, UnityEngine.Random.Range(0, 2), 0);
        else if (MovementScript.Brzina < 10) pozicija = new Vector3(UnityEngine.Random.Range(3,8), UnityEngine.Random.Range(0, 2), 0);
        else pozicija = new Vector3(UnityEngine.Random.Range(3, 8), UnityEngine.Random.Range(0, 7), 0);
        Instantiate(stickman[(int)UnityEngine.Random.Range(0, stickman.Length)], pozicija, transform.rotation);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListicCreator : MonoBehaviour {

    public GameObject[] mete;
    private float cooldown = -2f;
    public float cooldownAmount = 2;
    public Material[] materijal;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (cooldown < 0)
        {
            createMeta();
            cooldown = cooldownAmount;
        }
        cooldown -= Time.deltaTime;
    }
    ListicFactory factory = new ListicFactory();
    private void createMeta()
    {
        //na random y poziciji
        Vector2 pozicija = new Vector2(10, (UnityEngine.Random.Range(-2.3f, 3.4f)));
        //Instantiate(factory.getLisic("Zlatni"), pozicija, transform.rotation);
    }

    private class ListicFactory
    {
        Dictionary<String, GameObject> listici = new Dictionary<string, GameObject>();
        public GameObject getLisic(String boja) {
            if (listici.ContainsKey(boja))
            {
                return listici[boja];
            } else
            {
                listici.Add(boja, new GameObject()); //provjeri kako se tacno kreira instanca objekta sa nekom bojom, tj Material
                return listici[boja];
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

    int kojiIgrac = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void pokreniIgru1 ()
    {
        SceneManager.LoadScene("StrankaVasPrati");
        kojiIgrac = 1;
        
    }
    public void pokreniIgru2 ()
    {
        SceneManager.LoadScene("StrankaVasPrati");
        kojiIgrac = 2;
    }
    public void pokreniIgru3 ()
    {
        SceneManager.LoadScene("StrankaVasPrati");
        kojiIgrac = 3;
    }
    public void pokreniIgru4 ()
    {
        SceneManager.LoadScene("StrankaVasPrati");
        kojiIgrac = 4;
    }
    public void izlaz ()
    {
        Application.Quit();
    }
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        GameObject[] objekti = SceneManager.GetSceneByName("StrankaVasPrati").GetRootGameObjects();
        foreach (GameObject g in objekti)
        {
            if (kojiIgrac == 1)
            {
                if (g.name == "AE") g.transform.localScale = new Vector3(1, 1, 1);
                else if (g.name == "EE") g.transform.localScale = new Vector3(0, 0, 0);
                else if (g.name == "RI") g.transform.localScale = new Vector3(0, 0, 0);
                else if (g.name == "TK") g.transform.localScale = new Vector3(0, 0, 0);
            }
            else if (kojiIgrac==2)
            {
                if (g.name == "AE") g.transform.localScale = new Vector3(0, 0, 0);
                else if (g.name == "EE") g.transform.localScale = new Vector3(1, 1, 1);
                else if (g.name == "RI") g.transform.localScale = new Vector3(0, 0, 0);
                else if (g.name == "TK") g.transform.localScale = new Vector3(0, 0, 0);
            }
            else if (kojiIgrac == 3)
            {
                if (g.name == "AE") g.transform.localScale = new Vector3(0, 0, 0);
                else if (g.name == "EE") g.transform.localScale = new Vector3(0, 0, 0);
                else if (g.name == "RI") g.transform.localScale = new Vector3(1, 1, 1);
                else if (g.name == "TK") g.transform.localScale = new Vector3(0, 0, 0);
            }
            else if (kojiIgrac == 4)
            {
                if (g.name == "AE") g.transform.localScale = new Vector3(0, 0, 0);
                else if (g.name == "EE") g.transform.localScale = new Vector3(0, 0, 0);
                else if (g.name == "RI") g.transform.localScale = new Vector3(0, 0, 0);
                else if (g.name == "TK") g.transform.localScale = new Vector3(1, 1, 1);
            }
        }
    }
}

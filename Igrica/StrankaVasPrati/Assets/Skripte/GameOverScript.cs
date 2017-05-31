using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void izlaz()
    {
        Application.Quit();
    }
    public void Ponovi()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

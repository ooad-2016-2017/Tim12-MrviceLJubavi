using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SmanjiIgracaScript : MonoBehaviour
{
    void Start()
    {
        if (this.name=="AE" && MainMenuScript.kojiIgrac==1) transform.localScale = new Vector3(.5f, .5f, .5f);
        else if (this.name == "EE" && MainMenuScript.kojiIgrac == 2) transform.localScale = new Vector3(.5f, .5f, .5f);
        else if (this.name == "RI" && MainMenuScript.kojiIgrac == 3) transform.localScale = new Vector3(.5f, .5f, .5f);
        else if (this.name == "TK" && MainMenuScript.kojiIgrac == 4) transform.localScale = new Vector3(.5f, .5f, .5f);
    }
    void Update()
    {
    
    }
}
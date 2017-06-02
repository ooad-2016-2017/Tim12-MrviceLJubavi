using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnistiListic : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.name.Contains("AE1") || collision.collider.gameObject.name.Contains("EE1")|| collision.collider.gameObject.name.Contains("RI1") || collision.collider.gameObject.name.Contains("TK1"))
        {
            SceneManager.LoadScene("GameOverMenu");
        }
        else if (collision.collider.gameObject.name.Contains("Listic"))
        {
            Destroy(collision.collider.gameObject);
            bool obicni = true;
            //ovo ne radi, baca grešku
            //obicni=gameObject.GetComponent<Renderer>().material.GetColor("Gray") == Color.gray;
            MovementScript.Brzina += 0.1f;
            ListicBehavior.Brzina += 0.1f;
            if (SpawnEnemy.CooldownAmount > 2) SpawnEnemy.CooldownAmount /= 2;
            if (SpawnScript.Sekunde > 2) SpawnScript.Sekunde /= 2;
            if (obicni)
            {
                JumpingScript.Observer.Update1(JumpingScript.S);
            }
            else JumpingScript.Observer.Update5(JumpingScript.S);
        }
    }
}

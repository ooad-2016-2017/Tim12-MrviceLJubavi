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
            float ubrzanje = 1.2f;
            bool obicni = collision.collider.gameObject.tag.Contains("OListic");
            Destroy(collision.collider.gameObject);
            if (MovementScript.Brzina < 10)
            {
                MovementScript.Brzina += 0.2f;
                ListicBehavior.Brzina += 0.2f;
            }
            else
            {
                MovementScript.Brzina += 0.05f;
                ListicBehavior.Brzina += 0.05f;
            }
            if (MovementScript.Brzina < 10)
            {
                SpawnEnemy.CooldownAmount = Random.Range(0.7f, 2f);
                SpawnScript.Sekunde = Random.Range(1, 2f);
            }
            else if (MovementScript.Brzina < 30)
            {
                SpawnEnemy.CooldownAmount = Random.Range(0.2f, 0.8f);
                SpawnScript.Sekunde = Random.Range(0.2f, 0.8f);
            }
            else
            {
                SpawnEnemy.CooldownAmount = Random.Range(0.1f, 0.3f);
                SpawnScript.Sekunde = Random.Range(0.1f, 0.3f);
            }
            ubrzanje = ubrzanje * 2f;
            if (obicni)
            {
                JumpingScript.Observer.Update1(JumpingScript.S);
            }
            else JumpingScript.Observer.Update5(JumpingScript.S);
        }
    }
}

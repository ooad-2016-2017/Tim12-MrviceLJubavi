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
            float ubrzanje = 1.01f;
            bool obicni = collision.collider.gameObject.tag.Contains("OListic");
            Destroy(collision.collider.gameObject);
            MovementScript.Brzina += 0.1f;
            ListicBehavior.Brzina += 0.1f;
            if (SpawnEnemy.CooldownAmount > 2) SpawnEnemy.CooldownAmount /= ubrzanje ;
            if (SpawnScript.Sekunde > 2) SpawnScript.Sekunde /= ubrzanje;
            ubrzanje = ubrzanje * 1.01f;
            if (obicni)
            {
                JumpingScript.Observer.Update1(JumpingScript.S);
            }
            else JumpingScript.Observer.Update5(JumpingScript.S);
        }
    }
}

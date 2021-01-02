using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Krysztal : MonoBehaviour
{
    public GameObject czasteczki;

    private void Start()
    {
        string levelName = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetInt(levelName, 0);
    }

    private void OnTriggerEnter(Collider collision)
    {
        Scene scena = SceneManager.GetActiveScene();

        if (collision.name != "kula")
        {
            return;
        }

        //Debug.Log("Kolizja");

        if (IloscKrysztalowDoZdobycia() == 1)
        {
            //Debug.Log("Poziom został ukończony");

            string levelName = SceneManager.GetActiveScene().name;
            PlayerPrefs.SetInt(levelName, 1);

            if (scena.buildIndex == 2)
            {
                SceneManager.LoadScene("level2");
                //Debug.Log("Level2");
            }
            else if (scena.buildIndex == 3)
            {
                SceneManager.LoadScene("level3");
                //Debug.Log("Level3");
            }
            else if (scena.buildIndex == 4)
            {
                SceneManager.LoadScene("menu");
                //Debug.Log("Level3");
            }
        }
        else
        {
            Instantiate(czasteczki, transform.position, Quaternion.identity);
            GetComponent<AudioSource>().Play();
            Destroy(gameObject, 0.287f);
        }
    }

    int IloscKrysztalowDoZdobycia()
    {
        Krysztal[] krysztaly = Component.FindObjectsOfType<Krysztal>();
        return krysztaly.Length;
    }
}
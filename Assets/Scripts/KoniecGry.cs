using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KoniecGry : MonoBehaviour {

    void OnTriggerEnter(Collider colision) // ta funkcja przekazuje informacje dotyczącą kolizji
    {
        if(colision.name == "kula") // W momencie, gdy obiekt o nazwie kula wejdzie w interakcje z naszym komponentem np. z platformą z kolcami lub ścianą
        {
            //string nazwaPoziomu = Application.loadedLevelName; 
            string levelName = SceneManager.GetActiveScene().name; // Wtedy zostanie pobrana nazwa aktualnego poziomu
            SceneManager.LoadScene(levelName); // I zostanie on wczytany jeszcze raz
        }
        
    }
}

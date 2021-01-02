using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NazwaPoziomu : MonoBehaviour{

    string liczbaKrysztalow = "";
    public Text iloscKrysztalow;
    public TextMesh poziom;
    public TextMesh krysztaly;
    private object krysztal;

    void Start () {

        string nazwaPoziomu = SceneManager.GetActiveScene().name;
        poziom.text = nazwaPoziomu;
        
    }

    private void Update()
    {
        krysztaly.text = PozostaleKrysztaly().ToString();
        liczbaKrysztalow = PozostaleKrysztaly().ToString();
        iloscKrysztalow.text = liczbaKrysztalow;
    }

    int PozostaleKrysztaly()
    {
        Krysztal[] krysztaly = Component.FindObjectsOfType<Krysztal>();
        return krysztaly.Length;
    }
}

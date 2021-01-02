using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WybierzPoziom : MonoBehaviour {

    public TextMesh textMesh; 
    public string nazwaPoziomu;
    public GameObject okey;

	void Start ()
    {
        textMesh.text = nazwaPoziomu;

        if(PlayerPrefs.GetInt(nazwaPoziomu,0) == 0)
        {
            Destroy(okey);
        }
	}

    void OnMouseDown()
    {
        SceneManager.LoadScene(nazwaPoziomu);
    }
}
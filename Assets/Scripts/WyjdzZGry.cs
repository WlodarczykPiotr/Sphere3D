using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WyjdzZGry : MonoBehaviour {

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
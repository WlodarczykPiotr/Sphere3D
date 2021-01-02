using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RuchomaPlatforma : MonoBehaviour {

    public Vector3 przesuniecie;

    Vector3 pozycjaPoczatkowa;

	void Start ()
    {
        pozycjaPoczatkowa = transform.position;
	}
	
	void Update ()
    {
        float predkosc = 50f / przesuniecie.sqrMagnitude;
        float aktualnaPozycja = (Mathf.Sin(Time.timeSinceLevelLoad * predkosc) + 1f) / 2f;

        Rigidbody komponentFizyki = transform.GetComponent<Rigidbody>();
        komponentFizyki.position = Vector3.Lerp(pozycjaPoczatkowa, pozycjaPoczatkowa + przesuniecie, aktualnaPozycja);
	}

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        if (Selection.activeTransform == transform)
        {
            Gizmos.color = Color.blue;
        }

        Vector3 pozycjaKoncowa = transform.position + przesuniecie;
        Vector3 wielkosc = transform.rotation * transform.localScale * 2f;
        Gizmos.DrawWireCube(pozycjaKoncowa, wielkosc);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KontrolerKamery : MonoBehaviour
{ // Kod zwi¹zany z prac¹ kamer¹

    public Transform kula;

    int x = 0, y = 3, z = 5, obrot = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (obrot == 0)
            {
                z = 0;
                x = -5;
                obrot++;
            }
            else if (obrot == 1)
            {
                z = -5;
                x = 0;
                obrot++;
            }
            else if (obrot == 2)
            {
                z = 0;
                x = 5;
                obrot++;
            }
            else if (obrot == 3)
            {
                z = 5;
                x = 0;
                obrot = 0;
            }
        }

        Rigidbody komponentFizyki = kula.GetComponent<Rigidbody>(); // Na pocz¹tku ka¿dej klatki pobiera siê komponent fizyki z kuli
        Vector3 wektor = new Vector3(x, y, z); // Nastêpnie oblicza siê now¹ idealn¹ pozycjê dla kamery

        float predkosc = komponentFizyki.velocity.sqrMagnitude; // Nastêpnie pobiera siê prêdkoœæ kuli
        wektor = wektor * (1f + predkosc / 25f); // Zmienia siê odleg³oœæ kamery tak, aby zale¿a³a od prêdkoœci kuli

        Vector3 nowaPozycjaKamery = kula.position + wektor; // Nastêpnie oblicza siê now¹ pozycjê kamery

        transform.position = Vector3.Lerp(transform.position, nowaPozycjaKamery, Time.deltaTime * 2f); // I za pomoc¹ transformacji Lerp dostêpnej z komponentu Vector3 nadaje siê p³ynne poruszanie siê kamerze w ten sposób, ¿e informuje siê œrodowisko Unity aby aktualna pozycja kamery odrobinê zbli¿y³a siê do nowej idealnej pozycji
        transform.LookAt(kula); // Na sam koniec ka¿e siê kamerze aby patrzy³a dok³adnie w œrodek kuli
    }

    public int PobierzObrot()
    {
        return obrot;
    }
}

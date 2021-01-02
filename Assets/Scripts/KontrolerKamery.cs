using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KontrolerKamery : MonoBehaviour
{ // Kod zwi�zany z prac� kamer�

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

        Rigidbody komponentFizyki = kula.GetComponent<Rigidbody>(); // Na pocz�tku ka�dej klatki pobiera si� komponent fizyki z kuli
        Vector3 wektor = new Vector3(x, y, z); // Nast�pnie oblicza si� now� idealn� pozycj� dla kamery

        float predkosc = komponentFizyki.velocity.sqrMagnitude; // Nast�pnie pobiera si� pr�dko�� kuli
        wektor = wektor * (1f + predkosc / 25f); // Zmienia si� odleg�o�� kamery tak, aby zale�a�a od pr�dko�ci kuli

        Vector3 nowaPozycjaKamery = kula.position + wektor; // Nast�pnie oblicza si� now� pozycj� kamery

        transform.position = Vector3.Lerp(transform.position, nowaPozycjaKamery, Time.deltaTime * 2f); // I za pomoc� transformacji Lerp dost�pnej z komponentu Vector3 nadaje si� p�ynne poruszanie si� kamerze w ten spos�b, �e informuje si� �rodowisko Unity aby aktualna pozycja kamery odrobin� zbli�y�a si� do nowej idealnej pozycji
        transform.LookAt(kula); // Na sam koniec ka�e si� kamerze aby patrzy�a dok�adnie w �rodek kuli
    }

    public int PobierzObrot()
    {
        return obrot;
    }
}

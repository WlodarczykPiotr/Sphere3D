using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KontrolerKuli : MonoBehaviour
{
    int obrot = 3;
    Rigidbody komponentFizyki;

    private void Start()
    {
        komponentFizyki = transform.GetComponent<Rigidbody>(); // pobranie komponentu fizyki z kuli
    }

    void Update() // funkcja Update wywo³uje siê w trakcie ka¿dej klatki gry
    {
        Vector3 kierunek = Vector3.zero;// zmienna kierunek przechowuje odpowiedni kierunek obrotu kuli

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (obrot == 0) obrot++;
            else if (obrot == 1) obrot++;
            else if (obrot == 2) obrot++;
            else if (obrot == 3) obrot = 0;
        }

        if (obrot == 0)
        {
            if (Input.GetKey(KeyCode.UpArrow)) kierunek = Vector3.back;
            else if (Input.GetKey(KeyCode.DownArrow)) kierunek = Vector3.forward;
            else if (Input.GetKey(KeyCode.LeftArrow)) kierunek = Vector3.right;
            else if (Input.GetKey(KeyCode.RightArrow)) kierunek = Vector3.left;
        }
        else if (obrot == 1)
        {
            if (Input.GetKey(KeyCode.UpArrow)) kierunek = Vector3.right;
            else if (Input.GetKey(KeyCode.DownArrow)) kierunek = Vector3.left;
            else if (Input.GetKey(KeyCode.LeftArrow)) kierunek = Vector3.forward;
            else if (Input.GetKey(KeyCode.RightArrow)) kierunek = Vector3.back;
        }
        else if (obrot == 2)
        {
            if (Input.GetKey(KeyCode.UpArrow)) kierunek = Vector3.forward;
            else if (Input.GetKey(KeyCode.DownArrow)) kierunek = Vector3.back;
            else if (Input.GetKey(KeyCode.LeftArrow)) kierunek = Vector3.left;
            else if (Input.GetKey(KeyCode.RightArrow)) kierunek = Vector3.right;
        }
        else if (obrot == 3)
        {
            if (Input.GetKey(KeyCode.UpArrow)) kierunek = Vector3.left;
            else if (Input.GetKey(KeyCode.DownArrow)) kierunek = Vector3.right;
            else if (Input.GetKey(KeyCode.LeftArrow)) kierunek = Vector3.back;
            else if (Input.GetKey(KeyCode.RightArrow)) kierunek = Vector3.forward;
        }

        komponentFizyki.AddTorque(kierunek * 50f); // funkcja AddTorque dodaje moment obrotowy kuli, czyli szybkoœæ obrotu kuli
    }
}
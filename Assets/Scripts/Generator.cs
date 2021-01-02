using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject sfera;
    public Camera kamera;
    public Light swiatlo;

    public GameObject koniecGry;
    public GameObject nazwaPoziomu;

    void Start()
    {
        GameObject kula = GameObject.Instantiate(sfera);
        kula.name = "kula";
        kula.transform.position = transform.position + Vector3.up * 3f;

        Camera camera = GameObject.Instantiate(kamera);
        KontrolerKamery kontrolerKamery = camera.GetComponent<KontrolerKamery>();
        kontrolerKamery.kula = kula.transform;

        Light oswietlenie = GameObject.Instantiate(swiatlo);
        oswietlenie.color = Color.white;
        oswietlenie.intensity = 0.5f;

        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Flat;
        RenderSettings.ambientLight = Color.white * 0.6f;

        GameObject.Instantiate(koniecGry);
        GameObject.Instantiate(nazwaPoziomu);
    }
}
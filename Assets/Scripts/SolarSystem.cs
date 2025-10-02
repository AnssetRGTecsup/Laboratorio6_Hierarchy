using UnityEngine;

public class SolarSystem : MonoBehaviour
{
    [Header("Referencias")]
    public Transform sol;
    public Transform tierraPivot;
    public Transform tierra;
    public Transform lunaPivot;
    public Transform luna;
    public Transform satelitePivot;
    public Transform satelite;

    [Header("Velocidades de Rotación")]
    public float rotacionSol = 10f;
    public float orbitaTierra = 20f;
    public float rotacionTierra = 50f;
    public float orbitaLuna = 100f;
    public float rotacionLuna = 150f;
    public float orbitaSatelite = 200f;

    void Update()
    {
        // el sol rota sobre su eje
        sol.Rotate(Vector3.up * rotacionSol * Time.deltaTime);

        // la tierra orbita alrededor del Sol
        tierraPivot.Rotate(Vector3.up * orbitaTierra * Time.deltaTime);

        // la tierra rota sobre su propio eje
        tierra.Rotate(Vector3.up * rotacionTierra * Time.deltaTime);

        // la luna orbita alrededor de la tierra
        lunaPivot.Rotate(Vector3.up * orbitaLuna * Time.deltaTime);

        // la luna rota sobre su eje
        luna.Rotate(Vector3.up * rotacionLuna * Time.deltaTime);

        // el satelite orbita alrededor de la tierra
        satelitePivot.Rotate(Vector3.up * orbitaSatelite * Time.deltaTime);

        // el satelite siempre mira al Sol
        satelite.LookAt(sol);
    }
}

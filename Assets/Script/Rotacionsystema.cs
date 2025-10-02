using UnityEngine;

public class Rotacionsystema : MonoBehaviour
{
    [Header("Referencia al centro de la órbita")]
    public Transform centro;   

    [Header("Parámetros de órbita")]
    public float velocidadOrbita = 10f;  
    public float velocidadRotacion = 20f; 

    public Vector3 eje = Vector3.up;

    void Update()
    {
        if (centro != null)
        {
            transform.RotateAround(centro.position, eje, velocidadOrbita * Time.deltaTime);

            transform.Rotate(Vector3.up * velocidadRotacion * Time.deltaTime, Space.Self);
        }
    }
}

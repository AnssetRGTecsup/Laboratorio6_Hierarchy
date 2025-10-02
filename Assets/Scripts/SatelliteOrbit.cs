using UnityEngine;

public class SatelliteOrbit : MonoBehaviour
{
    [SerializeField] public Transform sol;

    void Update()
    {
        Vector3 direccion = sol.position - transform.position;
        Quaternion rotacion = Quaternion.LookRotation(direccion, Vector3.up);
        transform.rotation = rotacion;
    }
}

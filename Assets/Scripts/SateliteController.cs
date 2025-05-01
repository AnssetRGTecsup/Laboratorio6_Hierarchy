using UnityEngine;

public class SateliteController : MonoBehaviour
{
    public Transform objetivo; 

    void Update()
    {
        Vector3 direccion = objetivo.position - transform.position;
        transform.rotation = Quaternion.LookRotation(direccion);
    }
}

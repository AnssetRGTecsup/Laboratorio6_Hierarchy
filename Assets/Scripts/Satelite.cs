using UnityEngine;

public class Satellite : MonoBehaviour
{
    public Transform Sun; 

    void Update()
    {
        if (Sun != null)
        {
            Vector3 direccion = Sun.position - transform.position;

            Quaternion rotacion = Quaternion.LookRotation(direccion);

            transform.rotation = rotacion;
        }
    }

    void OnDrawGizmos()
    {
        if (Sun != null)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(transform.position, Sun.position);
        }
    }
}

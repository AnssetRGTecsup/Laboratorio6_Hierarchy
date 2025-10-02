using UnityEngine;

public class Sol : MonoBehaviour
{
    public float rotationSpeed = 10f;

    void Update()
    {
        Quaternion rot = Quaternion.AngleAxis(rotationSpeed * Time.deltaTime, Vector3.up);
        transform.rotation = rot * transform.rotation;
    }
}

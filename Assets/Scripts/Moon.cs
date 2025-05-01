using UnityEngine;

public class Moon : MonoBehaviour
{
    public Transform Earth;
    public float orbitSpeed = 30f;
    public float rotationSpeed = 5f;
    public float orbitRadius = 1f;

    void Update()
    {
        float angle = orbitSpeed * Time.time;
        transform.position = Earth.position + Quaternion.AngleAxis(angle, Vector3.up) * Vector3.forward * orbitRadius;

        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
using UnityEngine;

public class Earth : MonoBehaviour
{
    public Transform Sun;
    public float orbitSpeed = 20f;
    public float rotationSpeed = 10f;
    public float orbitRadius = 5f;

    void Update()
    {
        float angle = orbitSpeed * Time.time;
        transform.position = Sun.position + Quaternion.AngleAxis(angle, Vector3.up) * Vector3.forward * orbitRadius;

        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
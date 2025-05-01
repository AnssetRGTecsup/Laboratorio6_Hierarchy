using UnityEngine;

public class Satellite : MonoBehaviour
{
    public Transform Earth;
    public Transform Sun;
    public float orbitSpeed = 40f;
    public float orbitRadius = 0.5f;

    void Update()
    {
        float angle = orbitSpeed * Time.time;
        transform.position = Earth.position + Quaternion.AngleAxis(angle, Vector3.up) * Vector3.forward * orbitRadius;

        transform.LookAt(Sun);
    }
}
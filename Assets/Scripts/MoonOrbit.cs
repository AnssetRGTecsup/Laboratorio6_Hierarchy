using UnityEngine;

public class MoonOrbit : MonoBehaviour
{
    public float orbitSpeed = 40f;

    void Update()
    {
        Quaternion rot = Quaternion.AngleAxis(orbitSpeed * Time.deltaTime, Vector3.up);
        transform.rotation = rot * transform.rotation;
    }
}

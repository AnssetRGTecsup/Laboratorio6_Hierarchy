using UnityEngine;

public class EarthOrbit : MonoBehaviour
{
    public float orbitSpeed = 20f;

    void Update()
    {
        Quaternion rot = Quaternion.AngleAxis(orbitSpeed * Time.deltaTime, Vector3.up);
        transform.rotation = rot * transform.rotation;
    }
}

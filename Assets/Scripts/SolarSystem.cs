using UnityEngine;

public class SolarSystem : MonoBehaviour
{
    public Transform sun;
    public Transform earthOrbit;
    public Transform earth;
    public Transform moonOrbit;
    public Transform moon;
    public Transform satelliteOrbit;
    public Transform satellite;
    public Transform solarPanel;

    public float earthOrbitSpeed = 10f;
    public float earthRotationSpeed = 30f;
    public float moonOrbitSpeed = 50f;
    public float moonRotationSpeed = 50f;
    public float satelliteOrbitSpeed = 100f;

    void Update()
    {
        earthOrbit.Rotate(Vector3.up * earthOrbitSpeed * Time.deltaTime);

        earth.Rotate(Vector3.up * earthRotationSpeed * Time.deltaTime);

        moonOrbit.Rotate(Vector3.up * moonOrbitSpeed * Time.deltaTime);

        moon.Rotate(Vector3.up * moonRotationSpeed * Time.deltaTime);

        satelliteOrbit.Rotate(Vector3.up * satelliteOrbitSpeed * Time.deltaTime);

        Vector3 directionToSun = sun.position - solarPanel.position;
        Quaternion lookRotation = Quaternion.LookRotation(directionToSun.normalized);
        solarPanel.rotation = Quaternion.Slerp(solarPanel.rotation, lookRotation, Time.deltaTime * 5f);
    }
}


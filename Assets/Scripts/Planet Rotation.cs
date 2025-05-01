using Unity.Mathematics;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    [SerializeField] private Vector3 RotationVelocity = Vector3.zero;
    [SerializeField] private Transform transform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rotationPlanet = Quaternion.Euler(RotationVelocity * Time.deltaTime);
        transform.rotation = transform.rotation * rotationPlanet;

    }
}

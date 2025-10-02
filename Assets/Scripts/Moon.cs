using UnityEngine;

public class Moon : MonoBehaviour
{
    public float rotationSpeed = 30f;

    void Update()
    {
        Quaternion rot = Quaternion.AngleAxis(rotationSpeed * Time.deltaTime, Vector3.up);
        transform.rotation = rot * transform.rotation;
    }
}

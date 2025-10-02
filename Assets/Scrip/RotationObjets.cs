using UnityEngine;

public class Rotation_Objts : MonoBehaviour
{
    public float rotationSpeed = 20f; 
    public Vector3 rotationAxis = Vector3.up;
    void Update()
    {
        
        float angle = rotationSpeed * Time.deltaTime;


        Quaternion rotation = Quaternion.AngleAxis(angle, rotationAxis);

 
        transform.rotation = transform.rotation * rotation;
    }
}

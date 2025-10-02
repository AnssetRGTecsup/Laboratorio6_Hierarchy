using UnityEngine;

[ExecuteInEditMode]
public class Rotation : MonoBehaviour
{
    public Vector3 result;
    public float rotationSpeed = 45f; 
    private float currentRotation = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentRotation += rotationSpeed * Time.deltaTime;

        transform.rotation = Quaternion.Euler(0, currentRotation, 0);

        result = Vector3.forward * 5;
        result = transform.rotation * result;
    }

}

using UnityEngine;

[ExecuteInEditMode]
public class Transform : MonoBehaviour
{
    public Vector3 result;
    public float rotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        result = Vector3.forward * 5;
        result = Quaternion.Euler(0, rotation, 0) * result;
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(this.transform.position, this.transform.position + result);
    }
}

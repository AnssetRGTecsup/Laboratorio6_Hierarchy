using UnityEngine;

public class look : MonoBehaviour
{
    public Transform objetivo;

    void Update()
    {
        transform.LookAt(objetivo);
    }
}

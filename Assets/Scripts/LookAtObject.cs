using UnityEngine;

public class LookAtObject : MonoBehaviour
{
    public GameObject Sol; // arr�stralo desde el inspector

    void Update()
    {
        transform.LookAt(Sol.transform);
    }
}

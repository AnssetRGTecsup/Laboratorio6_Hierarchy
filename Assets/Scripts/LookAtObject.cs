using UnityEngine;

public class LookAtObject : MonoBehaviour
{
    public GameObject Sol; // arrástralo desde el inspector

    void Update()
    {
        transform.LookAt(Sol.transform);
    }
}

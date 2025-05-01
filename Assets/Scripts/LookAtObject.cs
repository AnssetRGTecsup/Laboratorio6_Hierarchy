using UnityEngine;

public class LookAtObject : MonoBehaviour
{
    public GameObject Sol;

    void Update()
    {
        transform.LookAt(Sol.transform);
    }
}

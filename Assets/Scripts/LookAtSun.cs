using UnityEngine;

public class LookAtSun : MonoBehaviour
{
    public Transform sun;

    void Update()
    {
        transform.LookAt(sun);
    }
}

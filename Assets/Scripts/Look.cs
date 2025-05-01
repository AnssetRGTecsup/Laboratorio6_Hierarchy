using UnityEngine;

public class Look : MonoBehaviour
{
    [SerializeField] private Transform target;

    void Update()
    {
        if (target != null)
        {
            transform.LookAt(target);
        }
    }
}

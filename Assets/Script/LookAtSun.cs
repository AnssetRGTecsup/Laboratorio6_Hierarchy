using UnityEngine;

public class LookAtSun : MonoBehaviour
{
    [SerializeField] private Transform Objective;

    private void Update()
    {
        transform.LookAt(Objective);
    }
}

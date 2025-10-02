using UnityEngine;

public class SolarPanelScript : MonoBehaviour
{
    [SerializeField] private Transform sunTransform;
    [SerializeField] private Vector3 offset;

    private void Update()
    {
        transform.LookAt(sunTransform);
        transform.Rotate(offset);
    }
}

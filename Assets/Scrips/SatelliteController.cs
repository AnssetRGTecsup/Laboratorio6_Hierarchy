using Mathematics.Week6;
using UnityEngine;

public class SatelliteController : MonoBehaviour
{
    public ConstantRotation3D Sun;
    protected virtual void FixedUpdate()
    {
        transform.rotation = Sun.transform.rotation;
    }
}

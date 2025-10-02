using UnityEngine;

public class rotationPlanet : MonoBehaviour{
    [SerializeField] protected Vector3 anglesVariations = Vector3.zero;
    [SerializeField] protected Vector3 velocityModifier = Vector3.one;

    protected Quaternion qx = Quaternion.identity; 
    protected Quaternion qy = Quaternion.identity; 
    protected Quaternion qz = Quaternion.identity; 

    protected Quaternion r = Quaternion.identity;

    protected float anguloSen;
    protected float anguloCos;

    protected virtual void FixedUpdate(){
        anglesVariations += (velocityModifier * Time.deltaTime);

        anguloSen = Mathf.Sin(Mathf.Deg2Rad * anglesVariations.z * 0.5f);
        anguloCos = Mathf.Cos(Mathf.Deg2Rad * anglesVariations.z * 0.5f);
        qz.Set(0, 0, anguloSen, anguloCos);

        anguloSen = Mathf.Sin(Mathf.Deg2Rad * anglesVariations.x * 0.5f);
        anguloCos = Mathf.Cos(Mathf.Deg2Rad * anglesVariations.x * 0.5f);
        qx.Set(anguloSen, 0, 0, anguloCos);

        anguloSen = Mathf.Sin(Mathf.Deg2Rad * anglesVariations.y * 0.5f);
        anguloCos = Mathf.Cos(Mathf.Deg2Rad * anglesVariations.y * 0.5f);
        qy.Set(0, anguloSen, 0, anguloCos);

        r = qy * qx * qz;

        transform.rotation = r;
    }
}

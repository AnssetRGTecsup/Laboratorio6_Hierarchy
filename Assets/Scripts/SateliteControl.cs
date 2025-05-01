using UnityEngine;

public class SateliteControl : MonoBehaviour
{
    [SerializeField] private Transform objectTransform;

    // Update is called once per frame
    void Update()
    {
        Vector3 ration = objectTransform.position - transform.position;
        transform.rotation = Quaternion.LookRotation(ration);

    }
}

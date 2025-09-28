using UnityEngine;

public class SmoothLookAtTurret : MonoBehaviour
{
    public Transform target;
    [Range(0.1f, 10f)]
    public float rotationSpeed = 5f;

    void Update()
    {
        if (target == null) return;

        Vector3 directionToTarget = (target.position - transform.position).normalized;
        Quaternion targetRotation = Quaternion.LookRotation(directionToTarget);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}

using UnityEngine;

public class RunnerCameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 followOffset;
    public float followSpeed;
    public bool canFollow;


    private void LateUpdate()
    {
        if (!canFollow)
        {
            return;
        }

        Vector3 desiredPos = transform.position - target.transform.position;

        transform.position = Vector3.Lerp(transform.position, desiredPos, Time.deltaTime * 5f);
    }
}

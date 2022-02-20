using UnityEngine;

public class RunnerCameraController : MonoBehaviour
{
    [SerializeField, Space(1f)] RunnerCameraControllerData camData;

    private RunnerCameraState camState;
    private Transform target;
    private Vector3 desiredPos;
    private Vector3 currentPos;
    private Vector3 velocity;

    private void Start()
    {
        SetState(RunnerCameraState.FOLLOW);
        SetTarget(FindObjectOfType<PlayerController>().transform);
    }

    private void LateUpdate()
    {
        if (camState == RunnerCameraState.STOP)
        {
            return;
        }

        currentPos = transform.position;
        desiredPos = (target.position + camData.FollowOffset);
        transform.position = Vector3.SmoothDamp(currentPos, desiredPos, ref velocity, camData.FollowSmootheness);
    }

    public void SetState(RunnerCameraState newState)
    {
        camState = newState;
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}

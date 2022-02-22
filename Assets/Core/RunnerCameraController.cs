using UnityEngine;

public class RunnerCameraController : MonoBehaviour
{
    [SerializeField, Space(1f)] RunnerCameraControllerData camData;

    private RunnerCameraState camState;
    private GameObject target;
    private Vector3 targetPos;
    private Vector3 desiredPos;
    private Vector3 velocity;

    private void LateUpdate()
    {
        Vector3 currentPos = transform.position;
        float posX = target.transform.position.x * (int)camData.AlongX;
        float posY = target.transform.position.y * (int)camData.AlongY;
        float posZ = target.transform.position.z * (int)camData.AlongZ;
        targetPos = new Vector3(posX, posY, posZ);
        desiredPos = (targetPos + camData.FollowOffset);
        transform.position = Vector3.SmoothDamp(currentPos, desiredPos, ref velocity, camData.FollowSmoothTime, camData.MaxFollowSpeed, Time.deltaTime * (int)camState);
    }

    public void SetState(RunnerCameraState newState)
    {
        camState = newState;
    }

    public void SetTarget(GameObject newTarget)
    {
        target = newTarget;
    }
}

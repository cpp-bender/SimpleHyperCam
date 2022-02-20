using UnityEngine;

[CreateAssetMenu(menuName = "Hyper Utilities/Runner Camera Settings", fileName = "Runner Camera Settings")]
public class RunnerCameraControllerData : ScriptableObject
{
    [SerializeField, Space(1f)] Vector3 followOffset = Vector3.forward * -5f;
    [SerializeField, Space(1f)] float followSmootheness = .5f;

    public Vector3 FollowOffset { get => followOffset; }
    public float FollowSmootheness { get => followSmootheness; }
}

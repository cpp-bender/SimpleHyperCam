using UnityEngine;

[CreateAssetMenu(menuName = "Hyper Utilities/Runner Camera Settings", fileName = "Runner Camera Settings")]
public class RunnerCameraControllerData : ScriptableObject
{
    [SerializeField, Space(5f)] Vector3 followOffset = Vector3.forward * -5f;
    [SerializeField, Space(5f)] float followSmoothTime = .5f;
    [SerializeField, Space(5f)] float maxFollowSpeed = 100f;
    [SerializeField, Space(5f)] RunnerCameraStatus alongX = RunnerCameraStatus.Maintain;
    [SerializeField, Space(5f)] RunnerCameraStatus alongY = RunnerCameraStatus.Maintain;
    [SerializeField, Space(5f)] RunnerCameraStatus alongZ = RunnerCameraStatus.Maintain;

    public Vector3 FollowOffset { get => followOffset; }
    public float FollowSmoothTime { get => followSmoothTime; }
    public float MaxFollowSpeed { get => maxFollowSpeed; }
    public RunnerCameraStatus AlongX { get => alongX; }
    public RunnerCameraStatus AlongY { get => alongY; }
    public RunnerCameraStatus AlongZ { get => alongZ; }
}

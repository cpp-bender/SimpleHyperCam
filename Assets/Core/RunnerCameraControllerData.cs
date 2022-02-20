using UnityEngine;

[CreateAssetMenu(menuName = "Hyper Utilities/Runner Camera Settings", fileName = "Runner Camera Settings")]
public class RunnerCameraControllerData : ScriptableObject
{
    [SerializeField, Space(1f)] Vector3 followOffset = Vector3.forward * -5f;
    [SerializeField, Space(1f)] float followSmootheness = .5f;
    [SerializeField, Space(1f)] RunnerCameraIgnoreLayer x = RunnerCameraIgnoreLayer.Maintain;
    [SerializeField, Space(1f)] RunnerCameraIgnoreLayer y = RunnerCameraIgnoreLayer.Maintain;
    [SerializeField, Space(1f)] RunnerCameraIgnoreLayer z = RunnerCameraIgnoreLayer.Maintain;

    public Vector3 FollowOffset { get => followOffset; }
    public float FollowSmootheness { get => followSmootheness; }
    public RunnerCameraIgnoreLayer X { get => x; }
    public RunnerCameraIgnoreLayer Y { get => y; }
    public RunnerCameraIgnoreLayer Z { get => z;}
}

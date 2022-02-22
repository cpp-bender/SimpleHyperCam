using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    public Camera mainCam;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        mainCam.GetComponent<RunnerCameraController>().SetTarget(FindObjectOfType<PlayerController>().gameObject);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mainCam.GetComponent<RunnerCameraController>().SetState(RunnerCameraState.STOP);
        }
        else if(Input.GetMouseButtonDown(1))
        {
            mainCam.GetComponent<RunnerCameraController>().SetState(RunnerCameraState.FOLLOW);
        }
    }
}

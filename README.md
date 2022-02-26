# Simple Hyper Cam



## Table Of Contents 
 
<details>
<summary>Details</summary>
  
  - [Introduction](#introduction)
  - [Usage](#usage)
  - [Disclaimer](#disclaimer)
    
</details>

## Introduction
A quick way to handle Camera Movement in runner-hyper-casual games without any if statements

## Usage

1 - At first, You need to attach "RunnerCameraController" script to your main camera and its settings

https://user-images.githubusercontent.com/59537269/155844861-7601d90b-d1a0-4403-8725-b5420f598276.mp4

2 -  After that, In order to make camera follow the target, You need to set its target and state

```csharp
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public RunnerCameraController mainCam;
    public GameObject target;

    private void Awake()
    {
        target = FindObjectOfType<PlayerController>().gameObject;
    }

    private void Start()
    {
        mainCam.SetTarget(target);
        mainCam.SetState(RunnerCameraState.FOLLOW);
    }
}

```
3 -  Now, If you hit play, You will see that camera smoothly follows the target

https://user-images.githubusercontent.com/59537269/155845016-beefa197-7d4e-4609-bee5-ebe143a3a02e.mp4


## Disclaimer

- If you want to stop the camera, You just need to use the public "SetState" method and pass in a "RunnerCameraState.STOP" argument
- Do not forget to set target by using the public "SetTarget" method before start up

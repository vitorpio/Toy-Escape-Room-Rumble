using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraPositionController : MonoBehaviour
{
    private CinemachineVirtualCamera cinemachineVirtualCamera;
    private CinemachineTransposer cinemachineTransposer;
    private CameraActions cameraActions;

    private float previousPressed = 0.0f;
    private float nextPressed = 0.0f;
    private bool cameraCanMove = true;
    private float cameraMoveReleaseTime = 0.1f;

    private Vector3[] cameraPositions = {
        new (0, 5, -5),
        new (-5, 5, 0),
        new (0, 5, 5),
        new(5, 5, 0)
    };

    public int currentCameraPostion = 0;
    public GizmoMovementController gizmoMovementController;

    void Awake()
    {
        cameraActions = new CameraActions();

        cinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>();
        cinemachineTransposer = cinemachineVirtualCamera.GetCinemachineComponent<CinemachineTransposer>();
    }

    void OnEnable()
    {
        cameraActions.CameraMap.Enable();
    }

    void OnDisable()
    {
        cameraActions.CameraMap.Disable();
    }


    void Update()
    {

        // Camera Movement
        if (cameraCanMove && !gizmoMovementController.isJumping)
        {
            previousPressed = cameraActions.CameraMap.Previous.ReadValue<float>();
            nextPressed = cameraActions.CameraMap.Next.ReadValue<float>();

            if (previousPressed == 1.0f)
            {
                if (currentCameraPostion == cameraPositions.Length - 1)
                {
                    currentCameraPostion = 0;
                }
                else
                {
                    currentCameraPostion += 1;
                }
                updateCameraPosition();
            }
            else if (nextPressed == 1.0f)
            {
                if (currentCameraPostion == 0)
                {
                    currentCameraPostion = cameraPositions.Length - 1;
                }
                else
                {
                    currentCameraPostion -= 1;
                }
                updateCameraPosition();
            }
        }
    }

    void updateCameraPosition()
    {
        cinemachineTransposer.m_FollowOffset = cameraPositions[currentCameraPostion];
        cameraCanMove = false;
        Invoke("releaseCameraMovement", cameraMoveReleaseTime);
    }

    void releaseCameraMovement()
    {
        cameraCanMove = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoCameraConreoller : MonoBehaviour
{
    private CameraActions cameraActions;

    private float previousPressed = 0.0f;
    private float nextPressed = 0.0f;
    private bool cameraCanMove = true;
    private float cameraMoveReleaseTime = 0.1f;

    private GizmoMovementController gizmoMovementController;
    private GizmoAttackController gizmoAttackController;
    private Transform transform;

    void Awake()
    {
        gizmoMovementController = GetComponent<GizmoMovementController>();
        gizmoAttackController = GetComponent<GizmoAttackController>();
        transform = GetComponent<Transform>();

        cameraActions = new CameraActions();
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
                updateCameraPosition(-90);
            }
            else if (nextPressed == 1.0f)
            {
                updateCameraPosition(90);
            }
        }
    }

    void updateCameraPosition(int yAxixRotation)
    {
        transform.Rotate(new Vector3(0, yAxixRotation, 0));
        cameraCanMove = false;
        Invoke("releaseCameraMovement", cameraMoveReleaseTime);
        // gizmoAttackController.updateAttackBoxPosition(gizmoTransform.rotation);
    }

    void releaseCameraMovement()
    {
        cameraCanMove = true;
    }
}

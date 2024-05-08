using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPositionController : MonoBehaviour
{
    private CameraActions cameraActions;

    private float previousPressed = 0.0f;
    private float nextPressed = 0.0f;
    private bool cameraCanMove = true;
    private float cameraMoveReleaseTime = 0.1f;

    public GizmoMovementController gizmoMovementController;
    public GizmoAttackController gizmoAttackController;
    public Transform gizmoTransform;

    void Awake()
    {
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
        gizmoTransform.Rotate(new Vector3(0, yAxixRotation, 0));
        cameraCanMove = false;
        Invoke("releaseCameraMovement", cameraMoveReleaseTime);
        // gizmoAttackController.updateAttackBoxPosition(gizmoTransform.rotation);
    }

    void releaseCameraMovement()
    {
        cameraCanMove = true;
    }
}

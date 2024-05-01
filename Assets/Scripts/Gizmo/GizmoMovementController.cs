using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class GizmoMovementController : MonoBehaviour
{
    private Rigidbody rigidbody;
    private GizmoActions gizmoActions;
    private Vector3 movementInput;
    private CameraPositionController cameraPositionController;

    private int[] movementAngles = {
        0,
        90,
        180,
        -90
    };

    public CinemachineVirtualCamera camera;
    public float movementSpeed;
    public float jumpForce;
    public bool isJumping = false;


    void Awake()
    {
        gizmoActions = new GizmoActions();
        rigidbody = GetComponent<Rigidbody>();
        cameraPositionController = camera.GetComponent<CameraPositionController>();
    }

    void OnEnable()
    {
        gizmoActions.GizmoMap.Enable();
    }

    void OnDisable()
    {
        gizmoActions.GizmoMap.Disable();
    }

    void FixedUpdate()
    {
        move();
        jump();
    }

    void move()
    {
        // Keyboard movement
        movementInput = gizmoActions.GizmoMap.Movement.ReadValue<Vector3>();

        // Movement angle based on camera position
        int angle = movementAngles[cameraPositionController.currentCameraPostion];

        // Gravity
        var gravity = new Vector3(0, rigidbody.velocity.y + Physics.gravity.y * Time.deltaTime, 0);

        rigidbody.velocity = (Quaternion.AngleAxis(angle, Vector3.up) * movementInput * movementSpeed) + gravity;
    }

    void jump()
    {
        if (gizmoActions.GizmoMap.Jump.ReadValue<float>() == 1.0f && !isJumping)
        {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isJumping = true;
        }
    }

}

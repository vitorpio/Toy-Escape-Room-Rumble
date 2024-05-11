using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class GizmoMovementController : MonoBehaviour
{
    private Rigidbody rigidbody;
    private Transform transform;
    private GizmoActions gizmoActions;
    private Vector3 movementInput;
    private GizmoAttackController gizmoAttackController;
    private GizmoAnimationController gizmoAnimationController;

    private float movementSpeed = 10.0f;
    private float jumpForce = 60.0f;

    public CinemachineVirtualCamera camera;
    public bool isJumping = false;
    public bool isMoving = false;


    void Awake()
    {
        gizmoActions = new GizmoActions();
        rigidbody = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();
        gizmoAttackController = GetComponentInChildren<GizmoAttackController>();
        gizmoAnimationController = GetComponentInChildren<GizmoAnimationController>();
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
        if (!gizmoAttackController.isAttacking)
        {
            jump();
        }
    }

    void move()
    {
        // Keyboard movement
        movementInput = gizmoActions.GizmoMap.Movement.ReadValue<Vector3>();

        isMoving = movementInput != Vector3.zero;
        gizmoAnimationController.UpdateMoving(isMoving);

        if (gizmoAttackController.isAttacking)
        {
            return;
        }

        // Gravity
        var gravity = new Vector3(0, rigidbody.velocity.y + Physics.gravity.y * Time.deltaTime, 0);

        rigidbody.velocity = (Quaternion.AngleAxis(transform.rotation.eulerAngles.y, Vector3.up) * movementInput * movementSpeed) + gravity;
    }

    void jump()
    {
        if (gizmoActions.GizmoMap.Jump.ReadValue<float>() == 1.0f && !isJumping && !gizmoAttackController.isAttacking)
        {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isJumping = true;
            gizmoAnimationController.UpdateJumping(isJumping);
        }
    }

}

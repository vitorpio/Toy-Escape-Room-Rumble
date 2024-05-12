using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoAttackController : MonoBehaviour
{
    private GizmoActions gizmoActions;
    private GizmoAnimationController gizmoAnimationController;
    private GizmoMovementController gizmoMovementController;
    private Rigidbody rigidbody;
    private float attackForce = 50.0f;

    public bool isAttacking = false;

    void Awake()
    {
        gizmoActions = new GizmoActions();
        gizmoAnimationController = GetComponent<GizmoAnimationController>();
        gizmoMovementController = GetComponent<GizmoMovementController>();
        rigidbody = GetComponent<Rigidbody>();
    }

    void OnEnable()
    {
        gizmoActions.GizmoMap.Enable();
    }

    void OnDisable()
    {
        gizmoActions.GizmoMap.Disable();
    }


    void Update()
    {
        attack();
    }

    void attack()
    {
        if (gizmoActions.GizmoMap.Attack.ReadValue<float>() == 1.0f && !isAttacking && !gizmoMovementController.isJumping)
        {
            isAttacking = true;
            rigidbody.AddForce(Vector3.forward * attackForce, ForceMode.Impulse);
            gizmoAnimationController.Attack();
        }
    }
}

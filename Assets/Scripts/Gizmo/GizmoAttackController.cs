using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoAttackController : MonoBehaviour
{
    private GizmoActions gizmoActions;
    private GizmoAnimationController gizmoAnimationController;
    private GizmoMovementController gizmoMovementController;

    public bool isAttacking = false;

    void Awake()
    {
        gizmoActions = new GizmoActions();
        gizmoAnimationController = GetComponent<GizmoAnimationController>();
        gizmoMovementController = GetComponent<GizmoMovementController>();
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
            gizmoAnimationController.Attack();
        }
    }
}

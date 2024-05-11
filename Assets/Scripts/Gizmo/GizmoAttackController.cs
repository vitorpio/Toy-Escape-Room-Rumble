using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoAttackController : MonoBehaviour
{
    private GizmoActions gizmoActions;
    private GizmoAnimationController gizmoAnimationController;
    private GizmoMovementController gizmoMovementController;

    private BoxCollider boxCollider;
    private Vector3[] attackBoxPositions = {
        new(0, 0.4f, 1.25f),
        new(1.25f, 0.4f, 0),
        new(0, 0.4f, -1.25f),
        new(-1.25f, 0.4f, 0),
    };

    public bool isAttacking = false;

    void Awake()
    {
        gizmoActions = new GizmoActions();
        gizmoAnimationController = GetComponentInParent<GizmoAnimationController>();
        gizmoMovementController = GetComponentInParent<GizmoMovementController>();
        boxCollider = GetComponent<BoxCollider>();
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


    public void updateAttackBoxPosition(int position)
    {
        boxCollider.center = attackBoxPositions[position];
    }
}

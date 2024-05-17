using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoAttackController : MonoBehaviour
{
    private GizmoActions gizmoActions;
    private GizmoAnimationController gizmoAnimationController;
    private GizmoMovementController gizmoMovementController;
    private GizmoSoundController gizmoSoundController;
    private Rigidbody rigidbody;
    private Transform transform;
    private float attackForce = 50.0f;

    public bool isAttacking = false;

    void Awake()
    {
        gizmoActions = new GizmoActions();
        gizmoAnimationController = GetComponent<GizmoAnimationController>();
        gizmoMovementController = GetComponent<GizmoMovementController>();
        gizmoSoundController = GetComponent<GizmoSoundController>();
        rigidbody = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();
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
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Quaternion.AngleAxis(transform.rotation.eulerAngles.y, Vector3.up) * Vector3.forward * attackForce, ForceMode.Impulse);
            gizmoAnimationController.Attack();
            gizmoSoundController.Attack();
        }
    }
}

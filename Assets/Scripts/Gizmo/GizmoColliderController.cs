using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoColliderController : MonoBehaviour
{
    GizmoMovementController gizmoMovementController;
    GizmoAnimationController gizmoAnimationController;

    void Awake()
    {
        gizmoMovementController = GetComponent<GizmoMovementController>();
        gizmoAnimationController = GetComponent<GizmoAnimationController>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor" && gizmoMovementController.isJumping)
        {
            gizmoMovementController.isJumping = false;
            gizmoAnimationController.UpdateJumping(gizmoMovementController.isJumping);
        }
    }

}

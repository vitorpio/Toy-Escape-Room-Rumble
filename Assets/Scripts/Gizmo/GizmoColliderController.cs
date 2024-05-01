using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoColliderController : MonoBehaviour
{
    GizmoMovementController gizmoMovementController;

    void Awake()
    {
        gizmoMovementController = GetComponent<GizmoMovementController>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor" && gizmoMovementController.isJumping)
        {
            gizmoMovementController.isJumping = false;
        }
    }

}

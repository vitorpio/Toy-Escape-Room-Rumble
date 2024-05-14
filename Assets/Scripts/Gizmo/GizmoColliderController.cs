using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoColliderController : MonoBehaviour
{
    GizmoMovementController gizmoMovementController;
    GizmoAnimationController gizmoAnimationController;
    public HealthController healthController;
    public BatteryController batteryController;

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

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Gear")
        {
            healthController.Heal();
            Destroy(other.gameObject);
        }
        else if (other.tag == "Battery")
        {
            batteryController.Recharge();
            Destroy(other.gameObject);
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoColliderController : MonoBehaviour
{
    private GizmoMovementController gizmoMovementController;
    private GizmoAnimationController gizmoAnimationController;
    private GizmoSoundController gizmoSoundController;

    public HealthController healthController;
    public BatteryController batteryController;

    void Awake()
    {
        gizmoMovementController = GetComponent<GizmoMovementController>();
        gizmoAnimationController = GetComponent<GizmoAnimationController>();
        gizmoSoundController = GetComponent<GizmoSoundController>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor" && gizmoMovementController.isJumping)
        {
            gizmoMovementController.isJumping = false;
            gizmoAnimationController.UpdateJumping(gizmoMovementController.isJumping);
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            healthController.TakeDamage();
            gizmoSoundController.TakeDamage();
            Recoil.ApplyRecoil(gameObject, collision.gameObject, 50.0f);
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

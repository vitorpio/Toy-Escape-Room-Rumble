using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoColliderController : MonoBehaviour
{
    private GizmoMovementController gizmoMovementController;
    private GizmoAnimationController gizmoAnimationController;
    private GizmoSoundController gizmoSoundController;
    private GizmoAttackController gizmoAttackController;
    private float enemyRecoilForce = 20.0f;

    private int kitesCollected = 0;
    private int totalKites = 3;

    public HealthController healthController;
    public BatteryController batteryController;

    void Awake()
    {
        gizmoMovementController = GetComponent<GizmoMovementController>();
        gizmoAnimationController = GetComponent<GizmoAnimationController>();
        gizmoSoundController = GetComponent<GizmoSoundController>();
        gizmoAttackController = GetComponent<GizmoAttackController>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor" && gizmoMovementController.isJumping)
        {
            gizmoMovementController.isJumping = false;
            gizmoAnimationController.UpdateJumping(gizmoMovementController.isJumping);
        }
        else if (collision.gameObject.tag == "Enemy" && !healthController.isTakingDamage)
        {
            if (gizmoAttackController.isAttacking)
            {
                Destroy(collision.gameObject);
            }
            else
            {
                gizmoSoundController.TakeDamage();
                if (healthController.TakeDamage())
                {
                    Recoil.ApplyRecoil(gameObject, collision.gameObject, enemyRecoilForce);
                }
            }
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
        else if (other.tag == "Kite")
        {
            kitesCollected += 1;
            Destroy(other.gameObject);
            if (kitesCollected == totalKites)
            {
                healthController.Respawn();
            }
        }

    }

}

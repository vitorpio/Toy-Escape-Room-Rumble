using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoAttackController : MonoBehaviour
{
    private GizmoActions gizmoActions;
    private BoxCollider boxCollider;

    private Vector3[] attackBoxPositions = {
        new(0, 0.4f, 1.25f),
        new(-1.25f, 0.4f, 0),
        new(0, 0.4f, -1.25f),
        new(1.25f, 0.4f, 0),
    };
    private float attackReleaseTime = 1f;

    public bool isAttacking = false;

    void Awake()
    {
        gizmoActions = new GizmoActions();
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
        if (gizmoActions.GizmoMap.Attack.ReadValue<float>() == 1.0f)
        {
            isAttacking = true;
            Invoke("releaseAttack", attackReleaseTime);
        }
    }

    void releaseAttack()
    {
        isAttacking = false;
    }


    public void updateAttackBoxPosition(int position)
    {
        boxCollider.center = attackBoxPositions[position];
    }
}

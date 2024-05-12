using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoAnimationController : MonoBehaviour
{
    private Animator animator;
    private string isMovingParameter = "IsMoving";
    private string isJumpingParameter = "IsJumping";
    private string attackParameter = "Attack";

    private AnimationClip attackAnimationClip;
    private GizmoAttackController gizmoAttackController;
    private string attackAnimationClipName = "Armature|new_attacking";


    void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        attackAnimationClip = Array.Find(animator.runtimeAnimatorController.animationClips, c => c.name == attackAnimationClipName);
        gizmoAttackController = GetComponentInChildren<GizmoAttackController>();
    }

    public void UpdateMoving(bool isMoving)
    {
        if (animator.GetBool(isMovingParameter) != isMoving)
        {
            animator.SetBool(isMovingParameter, isMoving);
        }
    }

    public void UpdateJumping(bool isJumping)
    {
        if (animator.GetBool(isJumpingParameter) != isJumping)
        {
            animator.SetBool(isJumpingParameter, isJumping);
        }
    }

    public void Attack()
    {
        animator.SetTrigger(attackParameter);
        Invoke("realeseAttack", attackAnimationClip.length);
    }

    void realeseAttack()
    {
        gizmoAttackController.isAttacking = false;
    }

}

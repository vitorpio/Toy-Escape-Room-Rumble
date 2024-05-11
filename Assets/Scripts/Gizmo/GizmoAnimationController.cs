using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoAnimationController : MonoBehaviour
{
    private Animator animator;
    private string isMovingParameter = "IsMoving";

    void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public void UpdateMoving(bool isMoving)
    {
        if (animator.GetBool(isMovingParameter) != isMoving)
        {
            animator.SetBool(isMovingParameter, isMoving);
        }
    }

}
